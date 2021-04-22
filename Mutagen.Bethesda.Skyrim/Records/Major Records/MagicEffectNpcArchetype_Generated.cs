/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Internals;
using Mutagen.Bethesda.Records;
using Mutagen.Bethesda.Records.Binary.Overlay;
using Mutagen.Bethesda.Records.Binary.Streams;
using Mutagen.Bethesda.Records.Binary.Translations;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Skyrim.Internals;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Skyrim
{
    #region Class
    public partial class MagicEffectNpcArchetype :
        MagicEffectArchetype,
        IEquatable<IMagicEffectNpcArchetypeGetter>,
        ILoquiObjectSetter<MagicEffectNpcArchetype>,
        IMagicEffectNpcArchetypeInternal
    {

        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            MagicEffectNpcArchetypeMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IMagicEffectNpcArchetypeGetter rhs) return false;
            return ((MagicEffectNpcArchetypeCommon)((IMagicEffectNpcArchetypeGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IMagicEffectNpcArchetypeGetter? obj)
        {
            return ((MagicEffectNpcArchetypeCommon)((IMagicEffectNpcArchetypeGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((MagicEffectNpcArchetypeCommon)((IMagicEffectNpcArchetypeGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            MagicEffectArchetype.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
            {
            }

            public Mask(
                TItem Type,
                TItem AssociationKey,
                TItem ActorValue)
            : base(
                Type: Type,
                AssociationKey: AssociationKey,
                ActorValue: ActorValue)
            {
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Equals
            public override bool Equals(object? obj)
            {
                if (!(obj is Mask<TItem> rhs)) return false;
                return Equals(rhs);
            }

            public bool Equals(Mask<TItem>? rhs)
            {
                if (rhs == null) return false;
                if (!base.Equals(rhs)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new MagicEffectNpcArchetype.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(MagicEffectNpcArchetype.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, MagicEffectNpcArchetype.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(MagicEffectNpcArchetype.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                }
                fg.AppendLine("]");
            }
            #endregion

        }

        public new class ErrorMask :
            MagicEffectArchetype.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                MagicEffectNpcArchetype_FieldIndex enu = (MagicEffectNpcArchetype_FieldIndex)index;
                switch (enu)
                {
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                MagicEffectNpcArchetype_FieldIndex enu = (MagicEffectNpcArchetype_FieldIndex)index;
                switch (enu)
                {
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                MagicEffectNpcArchetype_FieldIndex enu = (MagicEffectNpcArchetype_FieldIndex)index;
                switch (enu)
                {
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString()
            {
                var fg = new FileGeneration();
                ToString(fg, null);
                return fg.ToString();
            }

            public override void ToString(FileGeneration fg, string? name = null)
            {
                fg.AppendLine($"{(name ?? "ErrorMask")} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (this.Overall != null)
                    {
                        fg.AppendLine("Overall =>");
                        fg.AppendLine("[");
                        using (new DepthWrapper(fg))
                        {
                            fg.AppendLine($"{this.Overall}");
                        }
                        fg.AppendLine("]");
                    }
                    ToString_FillInternal(fg);
                }
                fg.AppendLine("]");
            }
            protected override void ToString_FillInternal(FileGeneration fg)
            {
                base.ToString_FillInternal(fg);
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static new ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public new class TranslationMask :
            MagicEffectArchetype.TranslationMask,
            ITranslationMask
        {
            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
            }

            #endregion

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => MagicEffectNpcArchetypeBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((MagicEffectNpcArchetypeBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #region Binary Create
        public new static MagicEffectNpcArchetype CreateFromBinary(
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new MagicEffectNpcArchetype();
            ((MagicEffectNpcArchetypeSetterCommon)((IMagicEffectNpcArchetypeGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out MagicEffectNpcArchetype item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(
                frame: frame,
                recordTypeConverter: recordTypeConverter);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((MagicEffectNpcArchetypeSetterCommon)((IMagicEffectNpcArchetypeGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new MagicEffectNpcArchetype GetNew()
        {
            return new MagicEffectNpcArchetype();
        }

    }
    #endregion

    #region Interface
    public partial interface IMagicEffectNpcArchetype :
        ILoquiObjectSetter<IMagicEffectNpcArchetypeInternal>,
        IMagicEffectArchetypeInternal,
        IMagicEffectNpcArchetypeGetter
    {
    }

    public partial interface IMagicEffectNpcArchetypeInternal :
        IMagicEffectArchetypeInternal,
        IMagicEffectNpcArchetype,
        IMagicEffectNpcArchetypeGetter
    {
    }

    public partial interface IMagicEffectNpcArchetypeGetter :
        IMagicEffectArchetypeGetter,
        IBinaryItem,
        ILoquiObject<IMagicEffectNpcArchetypeGetter>
    {
        static new ILoquiRegistration Registration => MagicEffectNpcArchetype_Registration.Instance;

    }

    #endregion

    #region Common MixIn
    public static partial class MagicEffectNpcArchetypeMixIn
    {
        public static void Clear(this IMagicEffectNpcArchetypeInternal item)
        {
            ((MagicEffectNpcArchetypeSetterCommon)((IMagicEffectNpcArchetypeGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static MagicEffectNpcArchetype.Mask<bool> GetEqualsMask(
            this IMagicEffectNpcArchetypeGetter item,
            IMagicEffectNpcArchetypeGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((MagicEffectNpcArchetypeCommon)((IMagicEffectNpcArchetypeGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IMagicEffectNpcArchetypeGetter item,
            string? name = null,
            MagicEffectNpcArchetype.Mask<bool>? printMask = null)
        {
            return ((MagicEffectNpcArchetypeCommon)((IMagicEffectNpcArchetypeGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IMagicEffectNpcArchetypeGetter item,
            FileGeneration fg,
            string? name = null,
            MagicEffectNpcArchetype.Mask<bool>? printMask = null)
        {
            ((MagicEffectNpcArchetypeCommon)((IMagicEffectNpcArchetypeGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IMagicEffectNpcArchetypeGetter item,
            IMagicEffectNpcArchetypeGetter rhs,
            MagicEffectNpcArchetype.TranslationMask? equalsMask = null)
        {
            return ((MagicEffectNpcArchetypeCommon)((IMagicEffectNpcArchetypeGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IMagicEffectNpcArchetypeInternal lhs,
            IMagicEffectNpcArchetypeGetter rhs,
            out MagicEffectNpcArchetype.ErrorMask errorMask,
            MagicEffectNpcArchetype.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((MagicEffectNpcArchetypeSetterTranslationCommon)((IMagicEffectNpcArchetypeGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = MagicEffectNpcArchetype.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IMagicEffectNpcArchetypeInternal lhs,
            IMagicEffectNpcArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((MagicEffectNpcArchetypeSetterTranslationCommon)((IMagicEffectNpcArchetypeGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static MagicEffectNpcArchetype DeepCopy(
            this IMagicEffectNpcArchetypeGetter item,
            MagicEffectNpcArchetype.TranslationMask? copyMask = null)
        {
            return ((MagicEffectNpcArchetypeSetterTranslationCommon)((IMagicEffectNpcArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static MagicEffectNpcArchetype DeepCopy(
            this IMagicEffectNpcArchetypeGetter item,
            out MagicEffectNpcArchetype.ErrorMask errorMask,
            MagicEffectNpcArchetype.TranslationMask? copyMask = null)
        {
            return ((MagicEffectNpcArchetypeSetterTranslationCommon)((IMagicEffectNpcArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static MagicEffectNpcArchetype DeepCopy(
            this IMagicEffectNpcArchetypeGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((MagicEffectNpcArchetypeSetterTranslationCommon)((IMagicEffectNpcArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IMagicEffectNpcArchetypeInternal item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((MagicEffectNpcArchetypeSetterCommon)((IMagicEffectNpcArchetypeGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim.Internals
{
    #region Field Index
    public enum MagicEffectNpcArchetype_FieldIndex
    {
        Type = 0,
        AssociationKey = 1,
        ActorValue = 2,
    }
    #endregion

    #region Registration
    public partial class MagicEffectNpcArchetype_Registration : ILoquiRegistration
    {
        public static readonly MagicEffectNpcArchetype_Registration Instance = new MagicEffectNpcArchetype_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 118,
            version: 0);

        public const string GUID = "c51eb111-5b35-4955-941d-91d3a8a00692";

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 3;

        public static readonly Type MaskType = typeof(MagicEffectNpcArchetype.Mask<>);

        public static readonly Type ErrorMaskType = typeof(MagicEffectNpcArchetype.ErrorMask);

        public static readonly Type ClassType = typeof(MagicEffectNpcArchetype);

        public static readonly Type GetterType = typeof(IMagicEffectNpcArchetypeGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IMagicEffectNpcArchetype);

        public static readonly Type? InternalSetterType = typeof(IMagicEffectNpcArchetypeInternal);

        public const string FullName = "Mutagen.Bethesda.Skyrim.MagicEffectNpcArchetype";

        public const string Name = "MagicEffectNpcArchetype";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(MagicEffectNpcArchetypeBinaryWriteTranslation);
        #region Interface
        ProtocolKey ILoquiRegistration.ProtocolKey => ProtocolKey;
        ObjectKey ILoquiRegistration.ObjectKey => ObjectKey;
        string ILoquiRegistration.GUID => GUID;
        ushort ILoquiRegistration.FieldCount => FieldCount;
        ushort ILoquiRegistration.AdditionalFieldCount => AdditionalFieldCount;
        Type ILoquiRegistration.MaskType => MaskType;
        Type ILoquiRegistration.ErrorMaskType => ErrorMaskType;
        Type ILoquiRegistration.ClassType => ClassType;
        Type ILoquiRegistration.SetterType => SetterType;
        Type? ILoquiRegistration.InternalSetterType => InternalSetterType;
        Type ILoquiRegistration.GetterType => GetterType;
        Type? ILoquiRegistration.InternalGetterType => InternalGetterType;
        string ILoquiRegistration.FullName => FullName;
        string ILoquiRegistration.Name => Name;
        string ILoquiRegistration.Namespace => Namespace;
        byte ILoquiRegistration.GenericCount => GenericCount;
        Type? ILoquiRegistration.GenericRegistrationType => GenericRegistrationType;
        ushort? ILoquiRegistration.GetNameIndex(StringCaseAgnostic name) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsEnumerable(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsLoqui(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsSingleton(ushort index) => throw new NotImplementedException();
        string ILoquiRegistration.GetNthName(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsNthDerivative(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsProtected(ushort index) => throw new NotImplementedException();
        Type ILoquiRegistration.GetNthType(ushort index) => throw new NotImplementedException();
        #endregion

    }
    #endregion

    #region Common
    public partial class MagicEffectNpcArchetypeSetterCommon : MagicEffectArchetypeSetterCommon
    {
        public new static readonly MagicEffectNpcArchetypeSetterCommon Instance = new MagicEffectNpcArchetypeSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IMagicEffectNpcArchetypeInternal item)
        {
            ClearPartial();
            base.Clear(item);
        }
        
        public override void Clear(IMagicEffectArchetypeInternal item)
        {
            Clear(item: (IMagicEffectNpcArchetypeInternal)item);
        }
        
        #region Mutagen
        public void RemapLinks(IMagicEffectNpcArchetype obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IMagicEffectNpcArchetypeInternal item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter,
                fillStructs: MagicEffectNpcArchetypeBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IMagicEffectArchetypeInternal item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            CopyInFromBinary(
                item: (MagicEffectNpcArchetype)item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }
        
        #endregion
        
    }
    public partial class MagicEffectNpcArchetypeCommon : MagicEffectArchetypeCommon
    {
        public new static readonly MagicEffectNpcArchetypeCommon Instance = new MagicEffectNpcArchetypeCommon();

        public MagicEffectNpcArchetype.Mask<bool> GetEqualsMask(
            IMagicEffectNpcArchetypeGetter item,
            IMagicEffectNpcArchetypeGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new MagicEffectNpcArchetype.Mask<bool>(false);
            ((MagicEffectNpcArchetypeCommon)((IMagicEffectNpcArchetypeGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IMagicEffectNpcArchetypeGetter item,
            IMagicEffectNpcArchetypeGetter rhs,
            MagicEffectNpcArchetype.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string ToString(
            IMagicEffectNpcArchetypeGetter item,
            string? name = null,
            MagicEffectNpcArchetype.Mask<bool>? printMask = null)
        {
            var fg = new FileGeneration();
            ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
            return fg.ToString();
        }
        
        public void ToString(
            IMagicEffectNpcArchetypeGetter item,
            FileGeneration fg,
            string? name = null,
            MagicEffectNpcArchetype.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"MagicEffectNpcArchetype =>");
            }
            else
            {
                fg.AppendLine($"{name} (MagicEffectNpcArchetype) =>");
            }
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
                ToStringFields(
                    item: item,
                    fg: fg,
                    printMask: printMask);
            }
            fg.AppendLine("]");
        }
        
        protected static void ToStringFields(
            IMagicEffectNpcArchetypeGetter item,
            FileGeneration fg,
            MagicEffectNpcArchetype.Mask<bool>? printMask = null)
        {
            MagicEffectArchetypeCommon.ToStringFields(
                item: item,
                fg: fg,
                printMask: printMask);
        }
        
        public static MagicEffectNpcArchetype_FieldIndex ConvertFieldIndex(MagicEffectArchetype_FieldIndex index)
        {
            switch (index)
            {
                case MagicEffectArchetype_FieldIndex.Type:
                    return (MagicEffectNpcArchetype_FieldIndex)((int)index);
                case MagicEffectArchetype_FieldIndex.AssociationKey:
                    return (MagicEffectNpcArchetype_FieldIndex)((int)index);
                case MagicEffectArchetype_FieldIndex.ActorValue:
                    return (MagicEffectNpcArchetype_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IMagicEffectNpcArchetypeGetter? lhs,
            IMagicEffectNpcArchetypeGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            if (!base.Equals((IMagicEffectArchetypeGetter)lhs, (IMagicEffectArchetypeGetter)rhs, crystal)) return false;
            return true;
        }
        
        public override bool Equals(
            IMagicEffectArchetypeGetter? lhs,
            IMagicEffectArchetypeGetter? rhs,
            TranslationCrystal? crystal)
        {
            return Equals(
                lhs: (IMagicEffectNpcArchetypeGetter?)lhs,
                rhs: rhs as IMagicEffectNpcArchetypeGetter,
                crystal: crystal);
        }
        
        public virtual int GetHashCode(IMagicEffectNpcArchetypeGetter item)
        {
            var hash = new HashCode();
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IMagicEffectArchetypeGetter item)
        {
            return GetHashCode(item: (IMagicEffectNpcArchetypeGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return MagicEffectNpcArchetype.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<FormLinkInformation> GetContainedFormLinks(IMagicEffectNpcArchetypeGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    public partial class MagicEffectNpcArchetypeSetterTranslationCommon : MagicEffectArchetypeSetterTranslationCommon
    {
        public new static readonly MagicEffectNpcArchetypeSetterTranslationCommon Instance = new MagicEffectNpcArchetypeSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IMagicEffectNpcArchetypeInternal item,
            IMagicEffectNpcArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                item,
                rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
        }
        
        public void DeepCopyIn(
            IMagicEffectNpcArchetype item,
            IMagicEffectNpcArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IMagicEffectArchetype)item,
                (IMagicEffectArchetypeGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
        }
        
        public override void DeepCopyIn(
            IMagicEffectArchetypeInternal item,
            IMagicEffectArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IMagicEffectNpcArchetypeInternal)item,
                rhs: (IMagicEffectNpcArchetypeGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        public override void DeepCopyIn(
            IMagicEffectArchetype item,
            IMagicEffectArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IMagicEffectNpcArchetype)item,
                rhs: (IMagicEffectNpcArchetypeGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public MagicEffectNpcArchetype DeepCopy(
            IMagicEffectNpcArchetypeGetter item,
            MagicEffectNpcArchetype.TranslationMask? copyMask = null)
        {
            MagicEffectNpcArchetype ret = (MagicEffectNpcArchetype)((MagicEffectNpcArchetypeCommon)((IMagicEffectNpcArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectNpcArchetypeSetterTranslationCommon)((IMagicEffectNpcArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public MagicEffectNpcArchetype DeepCopy(
            IMagicEffectNpcArchetypeGetter item,
            out MagicEffectNpcArchetype.ErrorMask errorMask,
            MagicEffectNpcArchetype.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            MagicEffectNpcArchetype ret = (MagicEffectNpcArchetype)((MagicEffectNpcArchetypeCommon)((IMagicEffectNpcArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectNpcArchetypeSetterTranslationCommon)((IMagicEffectNpcArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = MagicEffectNpcArchetype.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public MagicEffectNpcArchetype DeepCopy(
            IMagicEffectNpcArchetypeGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            MagicEffectNpcArchetype ret = (MagicEffectNpcArchetype)((MagicEffectNpcArchetypeCommon)((IMagicEffectNpcArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectNpcArchetypeSetterTranslationCommon)((IMagicEffectNpcArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: true);
            return ret;
        }
        
    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim
{
    public partial class MagicEffectNpcArchetype
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => MagicEffectNpcArchetype_Registration.Instance;
        public new static MagicEffectNpcArchetype_Registration Registration => MagicEffectNpcArchetype_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => MagicEffectNpcArchetypeCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return MagicEffectNpcArchetypeSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => MagicEffectNpcArchetypeSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class MagicEffectNpcArchetypeBinaryWriteTranslation :
        MagicEffectArchetypeBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new readonly static MagicEffectNpcArchetypeBinaryWriteTranslation Instance = new MagicEffectNpcArchetypeBinaryWriteTranslation();

        public void Write(
            MutagenWriter writer,
            IMagicEffectNpcArchetypeGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            MagicEffectArchetypeBinaryWriteTranslation.WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IMagicEffectNpcArchetypeGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public override void Write(
            MutagenWriter writer,
            IMagicEffectArchetypeGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IMagicEffectNpcArchetypeGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class MagicEffectNpcArchetypeBinaryCreateTranslation : MagicEffectArchetypeBinaryCreateTranslation
    {
        public new readonly static MagicEffectNpcArchetypeBinaryCreateTranslation Instance = new MagicEffectNpcArchetypeBinaryCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class MagicEffectNpcArchetypeBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class MagicEffectNpcArchetypeBinaryOverlay :
        MagicEffectArchetypeBinaryOverlay,
        IMagicEffectNpcArchetypeGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => MagicEffectNpcArchetype_Registration.Instance;
        public new static MagicEffectNpcArchetype_Registration Registration => MagicEffectNpcArchetype_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => MagicEffectNpcArchetypeCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => MagicEffectNpcArchetypeSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => MagicEffectNpcArchetypeBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((MagicEffectNpcArchetypeBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected MagicEffectNpcArchetypeBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static MagicEffectNpcArchetypeBinaryOverlay MagicEffectNpcArchetypeFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new MagicEffectNpcArchetypeBinaryOverlay(
                bytes: stream.RemainingMemory,
                package: package);
            int offset = stream.Position;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static MagicEffectNpcArchetypeBinaryOverlay MagicEffectNpcArchetypeFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            return MagicEffectNpcArchetypeFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                recordTypeConverter: recordTypeConverter);
        }

        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            MagicEffectNpcArchetypeMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IMagicEffectNpcArchetypeGetter rhs) return false;
            return ((MagicEffectNpcArchetypeCommon)((IMagicEffectNpcArchetypeGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IMagicEffectNpcArchetypeGetter? obj)
        {
            return ((MagicEffectNpcArchetypeCommon)((IMagicEffectNpcArchetypeGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((MagicEffectNpcArchetypeCommon)((IMagicEffectNpcArchetypeGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

