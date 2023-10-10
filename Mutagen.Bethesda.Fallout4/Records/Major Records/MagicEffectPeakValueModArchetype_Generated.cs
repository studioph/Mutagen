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
using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Fallout4.Internals;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Headers;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Cache;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Meta;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Fallout4.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Fallout4.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Fallout4
{
    #region Class
    public partial class MagicEffectPeakValueModArchetype :
        AMagicEffectArchetype,
        IEquatable<IMagicEffectPeakValueModArchetypeGetter>,
        ILoquiObjectSetter<MagicEffectPeakValueModArchetype>,
        IMagicEffectPeakValueModArchetype
    {
        #region Association
        private readonly IFormLink<IKeywordGetter> _Association = new FormLink<IKeywordGetter>();
        public IFormLink<IKeywordGetter> Association
        {
            get => _Association;
            set => _Association.SetTo(value);
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IFormLinkGetter<IKeywordGetter> IMagicEffectPeakValueModArchetypeGetter.Association => this.Association;
        #endregion

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            MagicEffectPeakValueModArchetypeMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IMagicEffectPeakValueModArchetypeGetter rhs) return false;
            return ((MagicEffectPeakValueModArchetypeCommon)((IMagicEffectPeakValueModArchetypeGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IMagicEffectPeakValueModArchetypeGetter? obj)
        {
            return ((MagicEffectPeakValueModArchetypeCommon)((IMagicEffectPeakValueModArchetypeGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((MagicEffectPeakValueModArchetypeCommon)((IMagicEffectPeakValueModArchetypeGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            AMagicEffectArchetype.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
            {
                this.Association = initialValue;
            }

            public Mask(
                TItem ActorValue,
                TItem Association)
            : base(ActorValue: ActorValue)
            {
                this.Association = Association;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Association;
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
                if (!object.Equals(this.Association, rhs.Association)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Association);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.Association)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.Association)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new MagicEffectPeakValueModArchetype.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.Association = eval(this.Association);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(MagicEffectPeakValueModArchetype.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, MagicEffectPeakValueModArchetype.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(MagicEffectPeakValueModArchetype.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.Association ?? true)
                    {
                        sb.AppendItem(Association, "Association");
                    }
                }
            }
            #endregion

        }

        public new class ErrorMask :
            AMagicEffectArchetype.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Association;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                MagicEffectPeakValueModArchetype_FieldIndex enu = (MagicEffectPeakValueModArchetype_FieldIndex)index;
                switch (enu)
                {
                    case MagicEffectPeakValueModArchetype_FieldIndex.Association:
                        return Association;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                MagicEffectPeakValueModArchetype_FieldIndex enu = (MagicEffectPeakValueModArchetype_FieldIndex)index;
                switch (enu)
                {
                    case MagicEffectPeakValueModArchetype_FieldIndex.Association:
                        this.Association = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                MagicEffectPeakValueModArchetype_FieldIndex enu = (MagicEffectPeakValueModArchetype_FieldIndex)index;
                switch (enu)
                {
                    case MagicEffectPeakValueModArchetype_FieldIndex.Association:
                        this.Association = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (Association != null) return true;
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
                {
                    sb.AppendItem(Association, "Association");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Association = this.Association.Combine(rhs.Association);
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
            AMagicEffectArchetype.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool Association;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
                this.Association = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((Association, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Mutagen
        public override IEnumerable<IFormLinkGetter> EnumerateFormLinks() => MagicEffectPeakValueModArchetypeCommon.Instance.EnumerateFormLinks(this);
        public override void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => MagicEffectPeakValueModArchetypeSetterCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => MagicEffectPeakValueModArchetypeBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((MagicEffectPeakValueModArchetypeBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static MagicEffectPeakValueModArchetype CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new MagicEffectPeakValueModArchetype();
            ((MagicEffectPeakValueModArchetypeSetterCommon)((IMagicEffectPeakValueModArchetypeGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out MagicEffectPeakValueModArchetype item,
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
            ((MagicEffectPeakValueModArchetypeSetterCommon)((IMagicEffectPeakValueModArchetypeGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new MagicEffectPeakValueModArchetype GetNew()
        {
            return new MagicEffectPeakValueModArchetype();
        }

    }
    #endregion

    #region Interface
    public partial interface IMagicEffectPeakValueModArchetype :
        IAMagicEffectArchetype,
        IFormLinkContainer,
        ILoquiObjectSetter<IMagicEffectPeakValueModArchetype>,
        IMagicEffectPeakValueModArchetypeGetter
    {
        new IFormLink<IKeywordGetter> Association { get; set; }
    }

    public partial interface IMagicEffectPeakValueModArchetypeGetter :
        IAMagicEffectArchetypeGetter,
        IBinaryItem,
        IFormLinkContainerGetter,
        ILoquiObject<IMagicEffectPeakValueModArchetypeGetter>
    {
        static new ILoquiRegistration StaticRegistration => MagicEffectPeakValueModArchetype_Registration.Instance;
        IFormLinkGetter<IKeywordGetter> Association { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class MagicEffectPeakValueModArchetypeMixIn
    {
        public static void Clear(this IMagicEffectPeakValueModArchetype item)
        {
            ((MagicEffectPeakValueModArchetypeSetterCommon)((IMagicEffectPeakValueModArchetypeGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static MagicEffectPeakValueModArchetype.Mask<bool> GetEqualsMask(
            this IMagicEffectPeakValueModArchetypeGetter item,
            IMagicEffectPeakValueModArchetypeGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((MagicEffectPeakValueModArchetypeCommon)((IMagicEffectPeakValueModArchetypeGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IMagicEffectPeakValueModArchetypeGetter item,
            string? name = null,
            MagicEffectPeakValueModArchetype.Mask<bool>? printMask = null)
        {
            return ((MagicEffectPeakValueModArchetypeCommon)((IMagicEffectPeakValueModArchetypeGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IMagicEffectPeakValueModArchetypeGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            MagicEffectPeakValueModArchetype.Mask<bool>? printMask = null)
        {
            ((MagicEffectPeakValueModArchetypeCommon)((IMagicEffectPeakValueModArchetypeGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IMagicEffectPeakValueModArchetypeGetter item,
            IMagicEffectPeakValueModArchetypeGetter rhs,
            MagicEffectPeakValueModArchetype.TranslationMask? equalsMask = null)
        {
            return ((MagicEffectPeakValueModArchetypeCommon)((IMagicEffectPeakValueModArchetypeGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                equalsMask: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IMagicEffectPeakValueModArchetype lhs,
            IMagicEffectPeakValueModArchetypeGetter rhs,
            out MagicEffectPeakValueModArchetype.ErrorMask errorMask,
            MagicEffectPeakValueModArchetype.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((MagicEffectPeakValueModArchetypeSetterTranslationCommon)((IMagicEffectPeakValueModArchetypeGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = MagicEffectPeakValueModArchetype.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IMagicEffectPeakValueModArchetype lhs,
            IMagicEffectPeakValueModArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((MagicEffectPeakValueModArchetypeSetterTranslationCommon)((IMagicEffectPeakValueModArchetypeGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static MagicEffectPeakValueModArchetype DeepCopy(
            this IMagicEffectPeakValueModArchetypeGetter item,
            MagicEffectPeakValueModArchetype.TranslationMask? copyMask = null)
        {
            return ((MagicEffectPeakValueModArchetypeSetterTranslationCommon)((IMagicEffectPeakValueModArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static MagicEffectPeakValueModArchetype DeepCopy(
            this IMagicEffectPeakValueModArchetypeGetter item,
            out MagicEffectPeakValueModArchetype.ErrorMask errorMask,
            MagicEffectPeakValueModArchetype.TranslationMask? copyMask = null)
        {
            return ((MagicEffectPeakValueModArchetypeSetterTranslationCommon)((IMagicEffectPeakValueModArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static MagicEffectPeakValueModArchetype DeepCopy(
            this IMagicEffectPeakValueModArchetypeGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((MagicEffectPeakValueModArchetypeSetterTranslationCommon)((IMagicEffectPeakValueModArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IMagicEffectPeakValueModArchetype item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((MagicEffectPeakValueModArchetypeSetterCommon)((IMagicEffectPeakValueModArchetypeGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Fallout4
{
    #region Field Index
    internal enum MagicEffectPeakValueModArchetype_FieldIndex
    {
        ActorValue = 0,
        Association = 1,
    }
    #endregion

    #region Registration
    internal partial class MagicEffectPeakValueModArchetype_Registration : ILoquiRegistration
    {
        public static readonly MagicEffectPeakValueModArchetype_Registration Instance = new MagicEffectPeakValueModArchetype_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Fallout4.ProtocolKey;

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(MagicEffectPeakValueModArchetype.Mask<>);

        public static readonly Type ErrorMaskType = typeof(MagicEffectPeakValueModArchetype.ErrorMask);

        public static readonly Type ClassType = typeof(MagicEffectPeakValueModArchetype);

        public static readonly Type GetterType = typeof(IMagicEffectPeakValueModArchetypeGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IMagicEffectPeakValueModArchetype);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Fallout4.MagicEffectPeakValueModArchetype";

        public const string Name = "MagicEffectPeakValueModArchetype";

        public const string Namespace = "Mutagen.Bethesda.Fallout4";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(MagicEffectPeakValueModArchetypeBinaryWriteTranslation);
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
    internal partial class MagicEffectPeakValueModArchetypeSetterCommon : AMagicEffectArchetypeSetterCommon
    {
        public new static readonly MagicEffectPeakValueModArchetypeSetterCommon Instance = new MagicEffectPeakValueModArchetypeSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IMagicEffectPeakValueModArchetype item)
        {
            ClearPartial();
            item.Association.Clear();
            base.Clear(item);
        }
        
        public override void Clear(IAMagicEffectArchetype item)
        {
            Clear(item: (IMagicEffectPeakValueModArchetype)item);
        }
        
        #region Mutagen
        public void RemapLinks(IMagicEffectPeakValueModArchetype obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
            obj.Association.Relink(mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IMagicEffectPeakValueModArchetype item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: MagicEffectPeakValueModArchetypeBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IAMagicEffectArchetype item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            CopyInFromBinary(
                item: (MagicEffectPeakValueModArchetype)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class MagicEffectPeakValueModArchetypeCommon : AMagicEffectArchetypeCommon
    {
        public new static readonly MagicEffectPeakValueModArchetypeCommon Instance = new MagicEffectPeakValueModArchetypeCommon();

        public MagicEffectPeakValueModArchetype.Mask<bool> GetEqualsMask(
            IMagicEffectPeakValueModArchetypeGetter item,
            IMagicEffectPeakValueModArchetypeGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new MagicEffectPeakValueModArchetype.Mask<bool>(false);
            ((MagicEffectPeakValueModArchetypeCommon)((IMagicEffectPeakValueModArchetypeGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IMagicEffectPeakValueModArchetypeGetter item,
            IMagicEffectPeakValueModArchetypeGetter rhs,
            MagicEffectPeakValueModArchetype.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            ret.Association = item.Association.Equals(rhs.Association);
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            IMagicEffectPeakValueModArchetypeGetter item,
            string? name = null,
            MagicEffectPeakValueModArchetype.Mask<bool>? printMask = null)
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
            IMagicEffectPeakValueModArchetypeGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            MagicEffectPeakValueModArchetype.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"MagicEffectPeakValueModArchetype =>");
            }
            else
            {
                sb.AppendLine($"{name} (MagicEffectPeakValueModArchetype) =>");
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
            IMagicEffectPeakValueModArchetypeGetter item,
            StructuredStringBuilder sb,
            MagicEffectPeakValueModArchetype.Mask<bool>? printMask = null)
        {
            AMagicEffectArchetypeCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
            if (printMask?.Association ?? true)
            {
                sb.AppendItem(item.Association.FormKey, "Association");
            }
        }
        
        public static MagicEffectPeakValueModArchetype_FieldIndex ConvertFieldIndex(AMagicEffectArchetype_FieldIndex index)
        {
            switch (index)
            {
                case AMagicEffectArchetype_FieldIndex.ActorValue:
                    return (MagicEffectPeakValueModArchetype_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IMagicEffectPeakValueModArchetypeGetter? lhs,
            IMagicEffectPeakValueModArchetypeGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IAMagicEffectArchetypeGetter)lhs, (IAMagicEffectArchetypeGetter)rhs, equalsMask)) return false;
            if ((equalsMask?.GetShouldTranslate((int)MagicEffectPeakValueModArchetype_FieldIndex.Association) ?? true))
            {
                if (!lhs.Association.Equals(rhs.Association)) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IAMagicEffectArchetypeGetter? lhs,
            IAMagicEffectArchetypeGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            return Equals(
                lhs: (IMagicEffectPeakValueModArchetypeGetter?)lhs,
                rhs: rhs as IMagicEffectPeakValueModArchetypeGetter,
                equalsMask: equalsMask);
        }
        
        public virtual int GetHashCode(IMagicEffectPeakValueModArchetypeGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Association);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IAMagicEffectArchetypeGetter item)
        {
            return GetHashCode(item: (IMagicEffectPeakValueModArchetypeGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return MagicEffectPeakValueModArchetype.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IMagicEffectPeakValueModArchetypeGetter obj)
        {
            foreach (var item in base.EnumerateFormLinks(obj))
            {
                yield return item;
            }
            yield return FormLinkInformation.Factory(obj.Association);
            yield break;
        }
        
        #endregion
        
    }
    internal partial class MagicEffectPeakValueModArchetypeSetterTranslationCommon : AMagicEffectArchetypeSetterTranslationCommon
    {
        public new static readonly MagicEffectPeakValueModArchetypeSetterTranslationCommon Instance = new MagicEffectPeakValueModArchetypeSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IMagicEffectPeakValueModArchetype item,
            IMagicEffectPeakValueModArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IAMagicEffectArchetype)item,
                (IAMagicEffectArchetypeGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)MagicEffectPeakValueModArchetype_FieldIndex.Association) ?? true))
            {
                item.Association.SetTo(rhs.Association.FormKey);
            }
        }
        
        
        public override void DeepCopyIn(
            IAMagicEffectArchetype item,
            IAMagicEffectArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IMagicEffectPeakValueModArchetype)item,
                rhs: (IMagicEffectPeakValueModArchetypeGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public MagicEffectPeakValueModArchetype DeepCopy(
            IMagicEffectPeakValueModArchetypeGetter item,
            MagicEffectPeakValueModArchetype.TranslationMask? copyMask = null)
        {
            MagicEffectPeakValueModArchetype ret = (MagicEffectPeakValueModArchetype)((MagicEffectPeakValueModArchetypeCommon)((IMagicEffectPeakValueModArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectPeakValueModArchetypeSetterTranslationCommon)((IMagicEffectPeakValueModArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public MagicEffectPeakValueModArchetype DeepCopy(
            IMagicEffectPeakValueModArchetypeGetter item,
            out MagicEffectPeakValueModArchetype.ErrorMask errorMask,
            MagicEffectPeakValueModArchetype.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            MagicEffectPeakValueModArchetype ret = (MagicEffectPeakValueModArchetype)((MagicEffectPeakValueModArchetypeCommon)((IMagicEffectPeakValueModArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectPeakValueModArchetypeSetterTranslationCommon)((IMagicEffectPeakValueModArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = MagicEffectPeakValueModArchetype.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public MagicEffectPeakValueModArchetype DeepCopy(
            IMagicEffectPeakValueModArchetypeGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            MagicEffectPeakValueModArchetype ret = (MagicEffectPeakValueModArchetype)((MagicEffectPeakValueModArchetypeCommon)((IMagicEffectPeakValueModArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectPeakValueModArchetypeSetterTranslationCommon)((IMagicEffectPeakValueModArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Fallout4
{
    public partial class MagicEffectPeakValueModArchetype
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => MagicEffectPeakValueModArchetype_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => MagicEffectPeakValueModArchetype_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => MagicEffectPeakValueModArchetypeCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return MagicEffectPeakValueModArchetypeSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => MagicEffectPeakValueModArchetypeSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Fallout4
{
    public partial class MagicEffectPeakValueModArchetypeBinaryWriteTranslation :
        AMagicEffectArchetypeBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new static readonly MagicEffectPeakValueModArchetypeBinaryWriteTranslation Instance = new();

        public static void WriteEmbedded(
            IMagicEffectPeakValueModArchetypeGetter item,
            MutagenWriter writer)
        {
            AMagicEffectArchetypeBinaryWriteTranslation.WriteEmbedded(
                item: item,
                writer: writer);
        }

        public void Write(
            MutagenWriter writer,
            IMagicEffectPeakValueModArchetypeGetter item,
            TypedWriteParams translationParams)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (IMagicEffectPeakValueModArchetypeGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IAMagicEffectArchetypeGetter item,
            TypedWriteParams translationParams)
        {
            Write(
                item: (IMagicEffectPeakValueModArchetypeGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class MagicEffectPeakValueModArchetypeBinaryCreateTranslation : AMagicEffectArchetypeBinaryCreateTranslation
    {
        public new static readonly MagicEffectPeakValueModArchetypeBinaryCreateTranslation Instance = new MagicEffectPeakValueModArchetypeBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IMagicEffectPeakValueModArchetype item,
            MutagenFrame frame)
        {
            AMagicEffectArchetypeBinaryCreateTranslation.FillBinaryStructs(
                item: item,
                frame: frame);
        }

    }

}
namespace Mutagen.Bethesda.Fallout4
{
    #region Binary Write Mixins
    public static class MagicEffectPeakValueModArchetypeBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Fallout4
{
}
#endregion

#endregion

