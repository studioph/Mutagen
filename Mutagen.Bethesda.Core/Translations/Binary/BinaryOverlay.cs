using Mutagen.Bethesda.Internals;
using Noggog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mutagen.Bethesda.Binary
{
    public abstract class BinaryOverlay
    {
        public delegate TryGet<int?> RecordTypeFillWrapper(
            BinaryMemoryReadStream stream,
            int finalPos,
            int offset,
            RecordType type,
            int? lastParsed,
            RecordTypeConverter? recordTypeConverter);
        public delegate TryGet<int?> ModTypeFillWrapper(
            IBinaryReadStream stream,
            long finalPos,
            int offset,
            RecordType type,
            int? lastParsed,
            RecordTypeConverter? recordTypeConverter);

        protected ReadOnlyMemorySlice<byte> _data;
        protected BinaryOverlayFactoryPackage _package;

        protected BinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
        {
            this._data = bytes;
            this._package = package;
        }

        public static void FillModTypes(
            IBinaryReadStream stream,
            ModTypeFillWrapper fill,
            BinaryOverlayFactoryPackage package)
        {
            int? lastParsed = null;
            ModHeader headerMeta = package.MetaData.Constants.GetMod(stream);
            var minimumFinalPos = checked((int)(stream.Position + headerMeta.TotalLength));
            fill(
                stream: stream,
                finalPos: minimumFinalPos,
                offset: 0,
                type: headerMeta.RecordType,
                lastParsed: lastParsed,
                recordTypeConverter: null);
            stream.Position = (int)headerMeta.TotalLength;
            while (!stream.Complete)
            {
                GroupHeader groupMeta = package.MetaData.Constants.GetGroup(stream);
                if (!groupMeta.IsGroup)
                {
                    throw new ArgumentException("Did not see GRUP header as expected.");
                }
                if (groupMeta.ContentLength == 0)
                {
                    stream.Position += groupMeta.TotalLength;
                    continue;
                }
                minimumFinalPos = checked((int)(stream.Position + groupMeta.TotalLength));
                var parsed = fill(
                    stream: stream,
                    finalPos: minimumFinalPos,
                    offset: 0,
                    type: groupMeta.ContainedRecordType,
                    lastParsed: lastParsed,
                    recordTypeConverter: null);
                if (parsed.Failed) break;
                if (minimumFinalPos > stream.Position)
                {
                    stream.Position = checked((int)minimumFinalPos);
                }
                lastParsed = parsed.Value;
            }
        }

        public void FillMajorRecords(
            BinaryMemoryReadStream stream,
            int finalPos,
            int offset,
            RecordTypeConverter? recordTypeConverter,
            RecordTypeFillWrapper fill)
        {
            int? lastParsed = null;
            while (!stream.Complete && stream.Position < finalPos)
            {
                MajorRecordHeader majorMeta = _package.MetaData.Constants.MajorRecord(stream.RemainingSpan);
                var minimumFinalPos = stream.Position + majorMeta.TotalLength;
                var parsed = fill(
                    stream: stream,
                    finalPos: finalPos,
                    offset: offset,
                    type: majorMeta.RecordType,
                    lastParsed: lastParsed,
                    recordTypeConverter: recordTypeConverter);
                if (parsed.Failed) break;
                if (minimumFinalPos > stream.Position)
                {
                    stream.Position = checked((int)minimumFinalPos);
                }
                lastParsed = parsed.Value;
            }
        }

        public void FillGroupRecordsForWrapper(
            BinaryMemoryReadStream stream,
            int finalPos,
            int offset,
            RecordTypeConverter? recordTypeConverter,
            RecordTypeFillWrapper fill)
        {
            int? lastParsed = null;
            while (!stream.Complete && stream.Position < finalPos)
            {
                GroupHeader groupMeta = _package.MetaData.Constants.Group(stream.RemainingSpan);
                if (!groupMeta.IsGroup)
                {
                    throw new DataMisalignedException();
                }
                var minimumFinalPos = stream.Position + groupMeta.TotalLength;
                var parsed = fill(
                    stream: stream,
                    finalPos: finalPos,
                    offset: offset,
                    type: groupMeta.RecordType,
                    lastParsed: lastParsed,
                    recordTypeConverter: recordTypeConverter);
                if (parsed.Failed) break;
                if (minimumFinalPos > stream.Position)
                {
                    stream.Position = checked((int)minimumFinalPos);
                }
                lastParsed = parsed.Value;
            }
        }

        public void FillSubrecordTypes(
            BinaryMemoryReadStream stream,
            int finalPos,
            int offset,
            RecordTypeConverter? recordTypeConverter,
            RecordTypeFillWrapper fill)
        {
            int? lastParsed = null;
            while (!stream.Complete && stream.Position < finalPos)
            {
                SubrecordHeader subMeta = _package.MetaData.Constants.Subrecord(stream.RemainingSpan);
                var minimumFinalPos = stream.Position + subMeta.TotalLength;
                var parsed = fill(
                    stream: stream,
                    finalPos: finalPos,
                    offset: offset,
                    type: subMeta.RecordType,
                    lastParsed: lastParsed,
                    recordTypeConverter: recordTypeConverter);
                if (parsed.Failed) break;
                if (minimumFinalPos > stream.Position)
                {
                    stream.Position = minimumFinalPos;
                }
                lastParsed = parsed.Value;
            }
        }

        public void FillTypelessSubrecordTypes(
            BinaryMemoryReadStream stream,
            int finalPos,
            int offset,
            RecordTypeConverter? recordTypeConverter,
            RecordTypeFillWrapper fill)
        {
            int? lastParsed = null;
            while (!stream.Complete && stream.Position < finalPos)
            {
                SubrecordHeader subMeta = _package.MetaData.Constants.Subrecord(stream.RemainingSpan);
                var minimumFinalPos = stream.Position + subMeta.TotalLength;
                var parsed = fill(
                    stream: stream,
                    finalPos: finalPos,
                    offset: offset,
                    type: subMeta.RecordType,
                    lastParsed: lastParsed,
                    recordTypeConverter: recordTypeConverter);
                if (parsed.Failed) break;
                if (minimumFinalPos > stream.Position)
                {
                    stream.Position = minimumFinalPos;
                }
                lastParsed = parsed.Value;
            }
        }

        public static int[] ParseRecordLocations(
            BinaryMemoryReadStream stream,
            long finalPos,
            RecordType trigger,
            RecordHeaderConstants constants,
            bool skipHeader,
            RecordTypeConverter? recordTypeConverter = null)
        {
            List<int> ret = new List<int>();
            var startingPos = stream.Position;
            while (!stream.Complete && stream.Position < finalPos)
            {
                var varMeta = constants.GetVariableMeta(stream);
                var recType = recordTypeConverter.ConvertToStandard(varMeta.RecordType);
                if (recType != trigger) break;
                if (skipHeader)
                {
                    stream.Position += varMeta.HeaderLength;
                    ret.Add(stream.Position - startingPos);
                    stream.Position += (int)varMeta.RecordLength;
                }
                else
                {
                    ret.Add(stream.Position - startingPos);
                    stream.Position += (int)varMeta.TotalLength;
                }
            }
            return ret.ToArray();
        }

        public static int[] ParseRecordLocations(
            BinaryMemoryReadStream stream,
            long finalPos,
            ICollectionGetter<RecordType> triggers,
            RecordHeaderConstants constants,
            bool skipHeader,
            RecordTypeConverter? recordTypeConverter = null)
        {
            List<int> ret = new List<int>();
            var startingPos = stream.Position;
            while (!stream.Complete && stream.Position < finalPos)
            {
                var varMeta = constants.GetVariableMeta(stream);
                var recType = recordTypeConverter.ConvertToStandard(varMeta.RecordType);
                if (!triggers.Contains(recType)) break;
                if (skipHeader)
                {
                    stream.Position += varMeta.HeaderLength;
                    ret.Add(stream.Position - startingPos);
                    stream.Position += (int)varMeta.RecordLength;
                }
                else
                {
                    ret.Add(stream.Position - startingPos);
                    stream.Position += (int)varMeta.TotalLength;
                }
            }
            return ret.ToArray();
        }

        public static int[] ParseRecordLocations(
            BinaryMemoryReadStream stream,
            long finalPos,
            ICollectionGetter<RecordType> triggers,
            ICollectionGetter<RecordType> includeTriggers,
            RecordHeaderConstants constants,
            bool skipHeader)
        {
            List<int> ret = new List<int>();
            var startingPos = stream.Position;
            while (!stream.Complete && stream.Position < finalPos)
            {
                var varMeta = constants.GetVariableMeta(stream);
                var recType = varMeta.RecordType;
                var trigger = triggers.Contains(recType);
                var includeTrigger = includeTriggers.Contains(recType);
                if (!trigger && !includeTrigger) break;
                if (trigger)
                {
                    if (skipHeader)
                    {
                        stream.Position += varMeta.HeaderLength;
                        ret.Add(stream.Position - startingPos);
                        stream.Position += (int)varMeta.RecordLength;
                    }
                    else
                    {
                        ret.Add(stream.Position - startingPos);
                        stream.Position += (int)varMeta.TotalLength;
                    }
                }
                else
                {
                    stream.Position += (int)varMeta.TotalLength;
                }
            }
            return ret.ToArray();
        }

        public static int[] ParseRecordLocations(
            BinaryMemoryReadStream stream,
            long finalPos,
            RecordType trigger,
            ICollectionGetter<RecordType> includeTriggers,
            RecordHeaderConstants constants,
            bool skipHeader)
        {
            List<int> ret = new List<int>();
            var startingPos = stream.Position;
            while (!stream.Complete && stream.Position < finalPos)
            {
                var varMeta = constants.GetVariableMeta(stream);
                var recType = varMeta.RecordType;
                var isTrigger = trigger == recType;
                var includeTrigger = includeTriggers.Contains(recType);
                if (!isTrigger && !includeTrigger) break;
                if (isTrigger)
                {
                    if (skipHeader)
                    {
                        stream.Position += varMeta.HeaderLength;
                        ret.Add(stream.Position - startingPos);
                        stream.Position += (int)varMeta.RecordLength;
                    }
                    else
                    {
                        ret.Add(stream.Position - startingPos);
                        stream.Position += (int)varMeta.TotalLength;
                    }
                }
                else
                {
                    stream.Position += (int)varMeta.TotalLength;
                }
            }
            return ret.ToArray();
        }

        public static int[] ParseRecordLocationsByCount(
            BinaryMemoryReadStream stream,
            uint count,
            RecordType trigger,
            RecordHeaderConstants constants,
            bool skipHeader)
        {
            List<int> ret = new List<int>();
            var startingPos = stream.Position;
            for (uint i = 0; i < count; i++)
            {
                var varMeta = constants.GetVariableMeta(stream);
                var recType = varMeta.RecordType;
                if (trigger == recType)
                {
                    if (skipHeader)
                    {
                        stream.Position += varMeta.HeaderLength;
                        ret.Add(stream.Position - startingPos);
                        stream.Position += (int)varMeta.RecordLength;
                    }
                    else
                    {
                        ret.Add(stream.Position - startingPos);
                        stream.Position += (int)varMeta.TotalLength;
                    }
                }
                else
                {
                    stream.Position += (int)varMeta.TotalLength;
                }
            }
            return ret.ToArray();
        }

        /// <summary>
        /// Finds locations of a number of records given by count that match a set of record types.
        /// A new location is marked each time a record type that has already been encounterd is seen
        /// </summary>
        /// <param name="stream">Stream to read and progress</param>
        /// <param name="count">Number of expected records</param>
        /// <param name="trigger">Set of record types expected within one record</param>
        /// <param name="constants">Metadata for reference</param>
        /// <param name="skipHeader">Whether to skip the header in the return location values</param>
        /// <returns>Array of located positions relative to the stream's position at the start</returns>
        public static int[] ParseRecordLocationsByCount(
            BinaryMemoryReadStream stream,
            uint count,
            ICollectionGetter<RecordType> trigger,
            RecordHeaderConstants constants,
            bool skipHeader)
        {
            var ret = new List<int>();
            var set = new HashSet<RecordType>();
            var startingPos = stream.Position;
            while (ret.Count < count)
            {
                var varMeta = constants.GetVariableMeta(stream);
                var recType = varMeta.RecordType;
                if (trigger.Contains(recType))
                {
                    // If new record type we haven't seen before in our current record, just continue
                    if (set.Add(recType) && ret.Count > 0)
                    {
                        stream.Position += (int)varMeta.TotalLength;
                        continue;
                    }

                    // Otherwise mark as a new record location
                    if (skipHeader)
                    {
                        stream.Position += varMeta.HeaderLength;
                        ret.Add(stream.Position - startingPos);
                        stream.Position += (int)varMeta.RecordLength;
                    }
                    else
                    {
                        ret.Add(stream.Position - startingPos);
                        stream.Position += (int)varMeta.TotalLength;
                    }

                    // Clear set of seen types
                    set.Clear();
                    set.Add(recType);
                }
                else
                {
                    stream.Position += (int)varMeta.TotalLength;
                }
            }
            return ret.ToArray();
        }

        public static int[] ParseRecordLocations(
            BinaryMemoryReadStream stream,
            long finalPos,
            ICollectionGetter<RecordType> triggers,
            RecordType includeTrigger,
            RecordHeaderConstants constants,
            bool skipHeader)
        {
            List<int> ret = new List<int>();
            var startingPos = stream.Position;
            while (!stream.Complete && stream.Position < finalPos)
            {
                var varMeta = constants.GetVariableMeta(stream);
                var recType = varMeta.RecordType;
                var trigger = triggers.Contains(recType);
                var isIncludeTrigger = recType == includeTrigger;
                if (!trigger && !isIncludeTrigger) break;
                if (trigger)
                {
                    if (skipHeader)
                    {
                        stream.Position += varMeta.HeaderLength;
                        ret.Add(stream.Position - startingPos);
                        stream.Position += (int)varMeta.RecordLength;
                    }
                    else
                    {
                        ret.Add(stream.Position - startingPos);
                        stream.Position += (int)varMeta.TotalLength;
                    }
                }
                else
                {
                    stream.Position += (int)varMeta.TotalLength;
                }
            }
            return ret.ToArray();
        }

        public static int[] ParseRecordLocations(
            BinaryMemoryReadStream stream,
            long finalPos,
            RecordType trigger,
            RecordType includeTrigger,
            RecordHeaderConstants constants,
            bool skipHeader)
        {
            List<int> ret = new List<int>();
            var startingPos = stream.Position;
            while (!stream.Complete && stream.Position < finalPos)
            {
                var varMeta = constants.GetVariableMeta(stream);
                var recType = varMeta.RecordType;
                var isTrigger = trigger == recType;
                var isIncludeTrigger = includeTrigger == recType;
                if (!isTrigger && !isIncludeTrigger) break;
                if (isTrigger)
                {
                    if (skipHeader)
                    {
                        stream.Position += varMeta.HeaderLength;
                        ret.Add(stream.Position - startingPos);
                        stream.Position += (int)varMeta.RecordLength;
                    }
                    else
                    {
                        ret.Add(stream.Position - startingPos);
                        stream.Position += (int)varMeta.TotalLength;
                    }
                }
                else
                {
                    stream.Position += (int)varMeta.TotalLength;
                }
            }
            return ret.ToArray();
        }

        public delegate T Factory<T>(
            BinaryMemoryReadStream stream,
            BinaryOverlayFactoryPackage package);

        public delegate T ConverterFactory<T>(
            BinaryMemoryReadStream stream,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter);

        public delegate T StreamFactory<T>(
            BinaryMemoryReadStream stream,
            BinaryOverlayFactoryPackage package);

        public delegate T StreamTypedFactory<T>(
            BinaryMemoryReadStream stream,
            RecordType recordType,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter);

        public delegate T SpanFactory<T>(
            ReadOnlyMemorySlice<byte> span,
            BinaryOverlayFactoryPackage package);

        public delegate T SpanRecordFactory<T>(
            ReadOnlyMemorySlice<byte> span,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter);

        public IReadOnlyList<T> ParseRepeatedTypelessSubrecord<T>(
            BinaryMemoryReadStream stream,
            ICollectionGetter<RecordType> trigger,
            StreamTypedFactory<T> factory,
            RecordTypeConverter? recordTypeConverter)
        {
            var ret = new List<T>();
            while (!stream.Complete)
            {
                var subMeta = _package.MetaData.Constants.GetSubrecord(stream);
                var recType = subMeta.RecordType;
                if (!trigger.Contains(recType)) break;
                var minimumFinalPos = stream.Position + subMeta.TotalLength;
                ret.Add(factory(stream, recType, _package, recordTypeConverter));
                if (stream.Position < minimumFinalPos)
                {
                    stream.Position = minimumFinalPos;
                }
            }
            return ret;
        }

        public IReadOnlyList<T> ParseRepeatedTypelessSubrecord<T>(
            BinaryMemoryReadStream stream,
            ICollectionGetter<RecordType> trigger,
            ConverterFactory<T> factory,
            RecordTypeConverter? recordTypeConverter)
        {
            return ParseRepeatedTypelessSubrecord(
                stream,
                trigger,
                (s, r, p, recConv) => factory(s, p, recConv),
                recordTypeConverter);
        }

        public IReadOnlyList<T> ParseRepeatedTypelessSubrecord<T>(
            BinaryMemoryReadStream stream,
            RecordType trigger,
            StreamTypedFactory<T> factory,
            RecordTypeConverter? recordTypeConverter)
        {
            var ret = new List<T>();
            while (!stream.Complete)
            {
                var subMeta = _package.MetaData.Constants.GetSubrecord(stream);
                var recType = subMeta.RecordType;
                if (trigger != recType) break;
                var minimumFinalPos = stream.Position + subMeta.TotalLength;
                ret.Add(factory(stream, recType, _package, recordTypeConverter));
                if (stream.Position < minimumFinalPos)
                {
                    stream.Position = minimumFinalPos;
                }
            }
            return ret;
        }

        public IReadOnlyList<T> ParseRepeatedTypelessSubrecord<T>(
            BinaryMemoryReadStream stream,
            RecordType trigger,
            SpanRecordFactory<T> factory,
            RecordTypeConverter? recordTypeConverter,
            bool skipHeader)
        {
            var ret = new List<T>();
            while (!stream.Complete)
            {
                var subMeta = _package.MetaData.Constants.GetSubrecord(stream);
                var recType = subMeta.RecordType;
                if (trigger != recType) break;
                var minimumFinalPos = stream.Position + subMeta.TotalLength;
                if (skipHeader)
                {
                    stream.Position += subMeta.HeaderLength;
                }
                ret.Add(factory(stream.ReadMemory(skipHeader ? subMeta.ContentLength : subMeta.TotalLength), _package, recordTypeConverter));
                if (stream.Position < minimumFinalPos)
                {
                    stream.Position = minimumFinalPos;
                }
            }
            return ret;
        }

        public IReadOnlyList<T> ParseRepeatedTypelessSubrecord<T>(
            BinaryMemoryReadStream stream,
            RecordType trigger,
            ConverterFactory<T> factory,
            RecordTypeConverter? recordTypeConverter)
        {
            return ParseRepeatedTypelessSubrecord(
                stream,
                trigger,
                (s, r, p, recConv) => factory(s, p, recConv),
                recordTypeConverter);
        }

        public static ReadOnlyMemorySlice<byte> LockExtractMemory(IBinaryReadStream stream, long min, long max)
        {
            lock (stream)
            {
                stream.Position = min;
                var size = checked((int)(max - min));
                if (stream is BinaryMemoryReadStream memReadStream)
                {
                    return stream.ReadMemory(size);
                }
                else
                {
                    byte[] data = new byte[size];
                    stream.Read(data);
                    return data;
                }
            }
        }
    }
}
