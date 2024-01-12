/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Interfaces;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Headers;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Meta;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Starfield.Internals;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Starfield.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Starfield.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Starfield
{
    #region Class
    public partial class RegionSounds :
        RegionData,
        IEquatable<IRegionSoundsGetter>,
        ILoquiObjectSetter<RegionSounds>,
        IRegionSounds
    {
        #region Ctor
        public RegionSounds()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion


        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            RegionSoundsMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IRegionSoundsGetter rhs) return false;
            return ((RegionSoundsCommon)((IRegionSoundsGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IRegionSoundsGetter? obj)
        {
            return ((RegionSoundsCommon)((IRegionSoundsGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((RegionSoundsCommon)((IRegionSoundsGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            RegionData.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
            {
            }

            public Mask(
                TItem Flags,
                TItem Priority)
            : base(
                Flags: Flags,
                Priority: Priority)
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
                var ret = new RegionSounds.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(RegionSounds.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, RegionSounds.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(RegionSounds.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                }
            }
            #endregion

        }

        public new class ErrorMask :
            RegionData.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                RegionSounds_FieldIndex enu = (RegionSounds_FieldIndex)index;
                switch (enu)
                {
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                RegionSounds_FieldIndex enu = (RegionSounds_FieldIndex)index;
                switch (enu)
                {
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                RegionSounds_FieldIndex enu = (RegionSounds_FieldIndex)index;
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
            public override string ToString() => this.Print();

            public override void Print(StructuredStringBuilder sb, string? name = null)
            {
                sb.AppendLine($"{(name ?? "ErrorMask")} =>");
                using (sb.Brace())
                {
                    if (this.Overall != null)
                    {
                        sb.AppendLine("Overall =>");
                        using (sb.Brace())
                        {
                            sb.AppendLine($"{this.Overall}");
                        }
                    }
                    PrintFillInternal(sb);
                }
            }
            protected override void PrintFillInternal(StructuredStringBuilder sb)
            {
                base.PrintFillInternal(sb);
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
            RegionData.TranslationMask,
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
        protected override object BinaryWriteTranslator => RegionSoundsBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((RegionSoundsBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static RegionSounds CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new RegionSounds();
            ((RegionSoundsSetterCommon)((IRegionSoundsGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out RegionSounds item,
            TypedParseParams translationParams = default)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(
                frame: frame,
                translationParams: translationParams);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        void IClearable.Clear()
        {
            ((RegionSoundsSetterCommon)((IRegionSoundsGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new RegionSounds GetNew()
        {
            return new RegionSounds();
        }

    }
    #endregion

    #region Interface
    public partial interface IRegionSounds :
        ILoquiObjectSetter<IRegionSounds>,
        IRegionData,
        IRegionSoundsGetter
    {
    }

    public partial interface IRegionSoundsGetter :
        IRegionDataGetter,
        IBinaryItem,
        ILoquiObject<IRegionSoundsGetter>
    {
        static new ILoquiRegistration StaticRegistration => RegionSounds_Registration.Instance;

    }

    #endregion

    #region Common MixIn
    public static partial class RegionSoundsMixIn
    {
        public static void Clear(this IRegionSounds item)
        {
            ((RegionSoundsSetterCommon)((IRegionSoundsGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static RegionSounds.Mask<bool> GetEqualsMask(
            this IRegionSoundsGetter item,
            IRegionSoundsGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((RegionSoundsCommon)((IRegionSoundsGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IRegionSoundsGetter item,
            string? name = null,
            RegionSounds.Mask<bool>? printMask = null)
        {
            return ((RegionSoundsCommon)((IRegionSoundsGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IRegionSoundsGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            RegionSounds.Mask<bool>? printMask = null)
        {
            ((RegionSoundsCommon)((IRegionSoundsGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IRegionSoundsGetter item,
            IRegionSoundsGetter rhs,
            RegionSounds.TranslationMask? equalsMask = null)
        {
            return ((RegionSoundsCommon)((IRegionSoundsGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                equalsMask: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IRegionSounds lhs,
            IRegionSoundsGetter rhs,
            out RegionSounds.ErrorMask errorMask,
            RegionSounds.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((RegionSoundsSetterTranslationCommon)((IRegionSoundsGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = RegionSounds.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IRegionSounds lhs,
            IRegionSoundsGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((RegionSoundsSetterTranslationCommon)((IRegionSoundsGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static RegionSounds DeepCopy(
            this IRegionSoundsGetter item,
            RegionSounds.TranslationMask? copyMask = null)
        {
            return ((RegionSoundsSetterTranslationCommon)((IRegionSoundsGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static RegionSounds DeepCopy(
            this IRegionSoundsGetter item,
            out RegionSounds.ErrorMask errorMask,
            RegionSounds.TranslationMask? copyMask = null)
        {
            return ((RegionSoundsSetterTranslationCommon)((IRegionSoundsGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static RegionSounds DeepCopy(
            this IRegionSoundsGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((RegionSoundsSetterTranslationCommon)((IRegionSoundsGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IRegionSounds item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((RegionSoundsSetterCommon)((IRegionSoundsGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Starfield
{
    #region Field Index
    internal enum RegionSounds_FieldIndex
    {
        Flags = 0,
        Priority = 1,
    }
    #endregion

    #region Registration
    internal partial class RegionSounds_Registration : ILoquiRegistration
    {
        public static readonly RegionSounds_Registration Instance = new RegionSounds_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Starfield.ProtocolKey;

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(RegionSounds.Mask<>);

        public static readonly Type ErrorMaskType = typeof(RegionSounds.ErrorMask);

        public static readonly Type ClassType = typeof(RegionSounds);

        public static readonly Type GetterType = typeof(IRegionSoundsGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IRegionSounds);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Starfield.RegionSounds";

        public const string Name = "RegionSounds";

        public const string Namespace = "Mutagen.Bethesda.Starfield";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly RecordType TriggeringRecordType = RecordTypes.RDAT;
        public static RecordTriggerSpecs TriggerSpecs => _recordSpecs.Value;
        private static readonly Lazy<RecordTriggerSpecs> _recordSpecs = new Lazy<RecordTriggerSpecs>(() =>
        {
            var all = RecordCollection.Factory(RecordTypes.RDAT);
            return new RecordTriggerSpecs(allRecordTypes: all);
        });
        public static readonly Type BinaryWriteTranslation = typeof(RegionSoundsBinaryWriteTranslation);
        #region Interface
        ProtocolKey ILoquiRegistration.ProtocolKey => ProtocolKey;
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
    internal partial class RegionSoundsSetterCommon : RegionDataSetterCommon
    {
        public new static readonly RegionSoundsSetterCommon Instance = new RegionSoundsSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IRegionSounds item)
        {
            ClearPartial();
            base.Clear(item);
        }
        
        public override void Clear(IRegionData item)
        {
            Clear(item: (IRegionSounds)item);
        }
        
        #region Mutagen
        public void RemapLinks(IRegionSounds obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IRegionSounds item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: RegionSoundsBinaryCreateTranslation.FillBinaryStructs,
                fillTyped: RegionSoundsBinaryCreateTranslation.FillBinaryRecordTypes);
        }
        
        public override void CopyInFromBinary(
            IRegionData item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            CopyInFromBinary(
                item: (RegionSounds)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class RegionSoundsCommon : RegionDataCommon
    {
        public new static readonly RegionSoundsCommon Instance = new RegionSoundsCommon();

        public RegionSounds.Mask<bool> GetEqualsMask(
            IRegionSoundsGetter item,
            IRegionSoundsGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new RegionSounds.Mask<bool>(false);
            ((RegionSoundsCommon)((IRegionSoundsGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IRegionSoundsGetter item,
            IRegionSoundsGetter rhs,
            RegionSounds.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            IRegionSoundsGetter item,
            string? name = null,
            RegionSounds.Mask<bool>? printMask = null)
        {
            var sb = new StructuredStringBuilder();
            Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
            return sb.ToString();
        }
        
        public void Print(
            IRegionSoundsGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            RegionSounds.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"RegionSounds =>");
            }
            else
            {
                sb.AppendLine($"{name} (RegionSounds) =>");
            }
            using (sb.Brace())
            {
                ToStringFields(
                    item: item,
                    sb: sb,
                    printMask: printMask);
            }
        }
        
        protected static void ToStringFields(
            IRegionSoundsGetter item,
            StructuredStringBuilder sb,
            RegionSounds.Mask<bool>? printMask = null)
        {
            RegionDataCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
        }
        
        public static RegionSounds_FieldIndex ConvertFieldIndex(RegionData_FieldIndex index)
        {
            switch (index)
            {
                case RegionData_FieldIndex.Flags:
                    return (RegionSounds_FieldIndex)((int)index);
                case RegionData_FieldIndex.Priority:
                    return (RegionSounds_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IRegionSoundsGetter? lhs,
            IRegionSoundsGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IRegionDataGetter)lhs, (IRegionDataGetter)rhs, equalsMask)) return false;
            return true;
        }
        
        public override bool Equals(
            IRegionDataGetter? lhs,
            IRegionDataGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            return Equals(
                lhs: (IRegionSoundsGetter?)lhs,
                rhs: rhs as IRegionSoundsGetter,
                equalsMask: equalsMask);
        }
        
        public virtual int GetHashCode(IRegionSoundsGetter item)
        {
            var hash = new HashCode();
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IRegionDataGetter item)
        {
            return GetHashCode(item: (IRegionSoundsGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return RegionSounds.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IRegionSoundsGetter obj)
        {
            foreach (var item in base.EnumerateFormLinks(obj))
            {
                yield return item;
            }
            yield break;
        }
        
        #endregion
        
    }
    internal partial class RegionSoundsSetterTranslationCommon : RegionDataSetterTranslationCommon
    {
        public new static readonly RegionSoundsSetterTranslationCommon Instance = new RegionSoundsSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IRegionSounds item,
            IRegionSoundsGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IRegionData)item,
                (IRegionDataGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
        }
        
        
        public override void DeepCopyIn(
            IRegionData item,
            IRegionDataGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IRegionSounds)item,
                rhs: (IRegionSoundsGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public RegionSounds DeepCopy(
            IRegionSoundsGetter item,
            RegionSounds.TranslationMask? copyMask = null)
        {
            RegionSounds ret = (RegionSounds)((RegionSoundsCommon)((IRegionSoundsGetter)item).CommonInstance()!).GetNew();
            ((RegionSoundsSetterTranslationCommon)((IRegionSoundsGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public RegionSounds DeepCopy(
            IRegionSoundsGetter item,
            out RegionSounds.ErrorMask errorMask,
            RegionSounds.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            RegionSounds ret = (RegionSounds)((RegionSoundsCommon)((IRegionSoundsGetter)item).CommonInstance()!).GetNew();
            ((RegionSoundsSetterTranslationCommon)((IRegionSoundsGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = RegionSounds.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public RegionSounds DeepCopy(
            IRegionSoundsGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            RegionSounds ret = (RegionSounds)((RegionSoundsCommon)((IRegionSoundsGetter)item).CommonInstance()!).GetNew();
            ((RegionSoundsSetterTranslationCommon)((IRegionSoundsGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Starfield
{
    public partial class RegionSounds
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => RegionSounds_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => RegionSounds_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => RegionSoundsCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return RegionSoundsSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => RegionSoundsSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Starfield
{
    public partial class RegionSoundsBinaryWriteTranslation :
        RegionDataBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new static readonly RegionSoundsBinaryWriteTranslation Instance = new();

        public void Write(
            MutagenWriter writer,
            IRegionSoundsGetter item,
            TypedWriteParams translationParams)
        {
            RegionDataBinaryWriteTranslation.WriteEmbedded(
                item: item,
                writer: writer);
            RegionDataBinaryWriteTranslation.WriteRecordTypes(
                item: item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (IRegionSoundsGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IRegionDataGetter item,
            TypedWriteParams translationParams)
        {
            Write(
                item: (IRegionSoundsGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class RegionSoundsBinaryCreateTranslation : RegionDataBinaryCreateTranslation
    {
        public new static readonly RegionSoundsBinaryCreateTranslation Instance = new RegionSoundsBinaryCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Starfield
{
    #region Binary Write Mixins
    public static class RegionSoundsBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Starfield
{
    internal partial class RegionSoundsBinaryOverlay :
        RegionDataBinaryOverlay,
        IRegionSoundsGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => RegionSounds_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => RegionSounds_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => RegionSoundsCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => RegionSoundsSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => RegionSoundsBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((RegionSoundsBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected RegionSoundsBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }

        public static IRegionSoundsGetter RegionSoundsFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            stream = ExtractTypelessSubrecordRecordMemory(
                stream: stream,
                meta: package.MetaData.Constants,
                translationParams: translationParams,
                memoryPair: out var memoryPair,
                offset: out var offset,
                finalPos: out var finalPos);
            var ret = new RegionSoundsBinaryOverlay(
                memoryPair: memoryPair,
                package: package);
            ret.FillTypelessSubrecordTypes(
                stream: stream,
                finalPos: stream.Length,
                offset: offset,
                translationParams: translationParams,
                fill: ret.FillRecordType);
            return ret;
        }

        public static IRegionSoundsGetter RegionSoundsFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            return RegionSoundsFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            RegionSoundsMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IRegionSoundsGetter rhs) return false;
            return ((RegionSoundsCommon)((IRegionSoundsGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IRegionSoundsGetter? obj)
        {
            return ((RegionSoundsCommon)((IRegionSoundsGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((RegionSoundsCommon)((IRegionSoundsGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

