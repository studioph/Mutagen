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
using Mutagen.Bethesda.Oblivion.Internals;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Headers;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Oblivion.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Oblivion.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Oblivion
{
    #region Class
    public partial class SkillBoost :
        IEquatable<ISkillBoostGetter>,
        ILoquiObjectSetter<SkillBoost>,
        ISkillBoost
    {
        #region Ctor
        public SkillBoost()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Skill
        public ActorValue Skill { get; set; } = default;
        #endregion
        #region Boost
        public SByte Boost { get; set; } = default;
        #endregion

        #region To String

        public void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            SkillBoostMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not ISkillBoostGetter rhs) return false;
            return ((SkillBoostCommon)((ISkillBoostGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(ISkillBoostGetter? obj)
        {
            return ((SkillBoostCommon)((ISkillBoostGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((SkillBoostCommon)((ISkillBoostGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
                this.Skill = initialValue;
                this.Boost = initialValue;
            }

            public Mask(
                TItem Skill,
                TItem Boost)
            {
                this.Skill = Skill;
                this.Boost = Boost;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Skill;
            public TItem Boost;
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
                if (!object.Equals(this.Skill, rhs.Skill)) return false;
                if (!object.Equals(this.Boost, rhs.Boost)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Skill);
                hash.Add(this.Boost);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.Skill)) return false;
                if (!eval(this.Boost)) return false;
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.Skill)) return true;
                if (eval(this.Boost)) return true;
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new SkillBoost.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.Skill = eval(this.Skill);
                obj.Boost = eval(this.Boost);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(SkillBoost.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, SkillBoost.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(SkillBoost.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.Skill ?? true)
                    {
                        sb.AppendItem(Skill, "Skill");
                    }
                    if (printMask?.Boost ?? true)
                    {
                        sb.AppendItem(Boost, "Boost");
                    }
                }
            }
            #endregion

        }

        public class ErrorMask :
            IErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Overall { get; set; }
            private List<string>? _warnings;
            public List<string> Warnings
            {
                get
                {
                    if (_warnings == null)
                    {
                        _warnings = new List<string>();
                    }
                    return _warnings;
                }
            }
            public Exception? Skill;
            public Exception? Boost;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                SkillBoost_FieldIndex enu = (SkillBoost_FieldIndex)index;
                switch (enu)
                {
                    case SkillBoost_FieldIndex.Skill:
                        return Skill;
                    case SkillBoost_FieldIndex.Boost:
                        return Boost;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                SkillBoost_FieldIndex enu = (SkillBoost_FieldIndex)index;
                switch (enu)
                {
                    case SkillBoost_FieldIndex.Skill:
                        this.Skill = ex;
                        break;
                    case SkillBoost_FieldIndex.Boost:
                        this.Boost = ex;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                SkillBoost_FieldIndex enu = (SkillBoost_FieldIndex)index;
                switch (enu)
                {
                    case SkillBoost_FieldIndex.Skill:
                        this.Skill = (Exception?)obj;
                        break;
                    case SkillBoost_FieldIndex.Boost:
                        this.Boost = (Exception?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (Skill != null) return true;
                if (Boost != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public void Print(StructuredStringBuilder sb, string? name = null)
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
            protected void PrintFillInternal(StructuredStringBuilder sb)
            {
                {
                    sb.AppendItem(Skill, "Skill");
                }
                {
                    sb.AppendItem(Boost, "Boost");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Skill = this.Skill.Combine(rhs.Skill);
                ret.Boost = this.Boost.Combine(rhs.Boost);
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public class TranslationMask : ITranslationMask
        {
            #region Members
            private TranslationCrystal? _crystal;
            public readonly bool DefaultOn;
            public bool OnOverall;
            public bool Skill;
            public bool Boost;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.Skill = defaultOn;
                this.Boost = defaultOn;
            }

            #endregion

            public TranslationCrystal GetCrystal()
            {
                if (_crystal != null) return _crystal;
                var ret = new List<(bool On, TranslationCrystal? SubCrystal)>();
                GetCrystal(ret);
                _crystal = new TranslationCrystal(ret.ToArray());
                return _crystal;
            }

            protected void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                ret.Add((Skill, null));
                ret.Add((Boost, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => SkillBoostBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((SkillBoostBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public static SkillBoost CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new SkillBoost();
            ((SkillBoostSetterCommon)((ISkillBoostGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out SkillBoost item,
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
            ((SkillBoostSetterCommon)((ISkillBoostGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static SkillBoost GetNew()
        {
            return new SkillBoost();
        }

    }
    #endregion

    #region Interface
    public partial interface ISkillBoost :
        ILoquiObjectSetter<ISkillBoost>,
        ISkillBoostGetter
    {
        new ActorValue Skill { get; set; }
        new SByte Boost { get; set; }
    }

    public partial interface ISkillBoostGetter :
        ILoquiObject,
        IBinaryItem,
        ILoquiObject<ISkillBoostGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration StaticRegistration => SkillBoost_Registration.Instance;
        ActorValue Skill { get; }
        SByte Boost { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class SkillBoostMixIn
    {
        public static void Clear(this ISkillBoost item)
        {
            ((SkillBoostSetterCommon)((ISkillBoostGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static SkillBoost.Mask<bool> GetEqualsMask(
            this ISkillBoostGetter item,
            ISkillBoostGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((SkillBoostCommon)((ISkillBoostGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this ISkillBoostGetter item,
            string? name = null,
            SkillBoost.Mask<bool>? printMask = null)
        {
            return ((SkillBoostCommon)((ISkillBoostGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this ISkillBoostGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            SkillBoost.Mask<bool>? printMask = null)
        {
            ((SkillBoostCommon)((ISkillBoostGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this ISkillBoostGetter item,
            ISkillBoostGetter rhs,
            SkillBoost.TranslationMask? equalsMask = null)
        {
            return ((SkillBoostCommon)((ISkillBoostGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                equalsMask: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this ISkillBoost lhs,
            ISkillBoostGetter rhs)
        {
            ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this ISkillBoost lhs,
            ISkillBoostGetter rhs,
            SkillBoost.TranslationMask? copyMask = null)
        {
            ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this ISkillBoost lhs,
            ISkillBoostGetter rhs,
            out SkillBoost.ErrorMask errorMask,
            SkillBoost.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = SkillBoost.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this ISkillBoost lhs,
            ISkillBoostGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static SkillBoost DeepCopy(
            this ISkillBoostGetter item,
            SkillBoost.TranslationMask? copyMask = null)
        {
            return ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static SkillBoost DeepCopy(
            this ISkillBoostGetter item,
            out SkillBoost.ErrorMask errorMask,
            SkillBoost.TranslationMask? copyMask = null)
        {
            return ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static SkillBoost DeepCopy(
            this ISkillBoostGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this ISkillBoost item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((SkillBoostSetterCommon)((ISkillBoostGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Oblivion
{
    #region Field Index
    internal enum SkillBoost_FieldIndex
    {
        Skill = 0,
        Boost = 1,
    }
    #endregion

    #region Registration
    internal partial class SkillBoost_Registration : ILoquiRegistration
    {
        public static readonly SkillBoost_Registration Instance = new SkillBoost_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Oblivion.ProtocolKey;

        public const ushort AdditionalFieldCount = 2;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(SkillBoost.Mask<>);

        public static readonly Type ErrorMaskType = typeof(SkillBoost.ErrorMask);

        public static readonly Type ClassType = typeof(SkillBoost);

        public static readonly Type GetterType = typeof(ISkillBoostGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(ISkillBoost);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Oblivion.SkillBoost";

        public const string Name = "SkillBoost";

        public const string Namespace = "Mutagen.Bethesda.Oblivion";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(SkillBoostBinaryWriteTranslation);
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
    internal partial class SkillBoostSetterCommon
    {
        public static readonly SkillBoostSetterCommon Instance = new SkillBoostSetterCommon();

        partial void ClearPartial();
        
        public void Clear(ISkillBoost item)
        {
            ClearPartial();
            item.Skill = default;
            item.Boost = default;
        }
        
        #region Mutagen
        public void RemapLinks(ISkillBoost obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            ISkillBoost item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: SkillBoostBinaryCreateTranslation.FillBinaryStructs);
        }
        
        #endregion
        
    }
    internal partial class SkillBoostCommon
    {
        public static readonly SkillBoostCommon Instance = new SkillBoostCommon();

        public SkillBoost.Mask<bool> GetEqualsMask(
            ISkillBoostGetter item,
            ISkillBoostGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new SkillBoost.Mask<bool>(false);
            ((SkillBoostCommon)((ISkillBoostGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            ISkillBoostGetter item,
            ISkillBoostGetter rhs,
            SkillBoost.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            ret.Skill = item.Skill == rhs.Skill;
            ret.Boost = item.Boost == rhs.Boost;
        }
        
        public string Print(
            ISkillBoostGetter item,
            string? name = null,
            SkillBoost.Mask<bool>? printMask = null)
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
            ISkillBoostGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            SkillBoost.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"SkillBoost =>");
            }
            else
            {
                sb.AppendLine($"{name} (SkillBoost) =>");
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
            ISkillBoostGetter item,
            StructuredStringBuilder sb,
            SkillBoost.Mask<bool>? printMask = null)
        {
            if (printMask?.Skill ?? true)
            {
                sb.AppendItem(item.Skill, "Skill");
            }
            if (printMask?.Boost ?? true)
            {
                sb.AppendItem(item.Boost, "Boost");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            ISkillBoostGetter? lhs,
            ISkillBoostGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if ((equalsMask?.GetShouldTranslate((int)SkillBoost_FieldIndex.Skill) ?? true))
            {
                if (lhs.Skill != rhs.Skill) return false;
            }
            if ((equalsMask?.GetShouldTranslate((int)SkillBoost_FieldIndex.Boost) ?? true))
            {
                if (lhs.Boost != rhs.Boost) return false;
            }
            return true;
        }
        
        public virtual int GetHashCode(ISkillBoostGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Skill);
            hash.Add(item.Boost);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return SkillBoost.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(ISkillBoostGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    internal partial class SkillBoostSetterTranslationCommon
    {
        public static readonly SkillBoostSetterTranslationCommon Instance = new SkillBoostSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            ISkillBoost item,
            ISkillBoostGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)SkillBoost_FieldIndex.Skill) ?? true))
            {
                item.Skill = rhs.Skill;
            }
            if ((copyMask?.GetShouldTranslate((int)SkillBoost_FieldIndex.Boost) ?? true))
            {
                item.Boost = rhs.Boost;
            }
        }
        
        #endregion
        
        public SkillBoost DeepCopy(
            ISkillBoostGetter item,
            SkillBoost.TranslationMask? copyMask = null)
        {
            SkillBoost ret = (SkillBoost)((SkillBoostCommon)((ISkillBoostGetter)item).CommonInstance()!).GetNew();
            ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public SkillBoost DeepCopy(
            ISkillBoostGetter item,
            out SkillBoost.ErrorMask errorMask,
            SkillBoost.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            SkillBoost ret = (SkillBoost)((SkillBoostCommon)((ISkillBoostGetter)item).CommonInstance()!).GetNew();
            ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = SkillBoost.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public SkillBoost DeepCopy(
            ISkillBoostGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            SkillBoost ret = (SkillBoost)((SkillBoostCommon)((ISkillBoostGetter)item).CommonInstance()!).GetNew();
            ((SkillBoostSetterTranslationCommon)((ISkillBoostGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Oblivion
{
    public partial class SkillBoost
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => SkillBoost_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => SkillBoost_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => SkillBoostCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return SkillBoostSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => SkillBoostSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object ISkillBoostGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object ISkillBoostGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object ISkillBoostGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Oblivion
{
    public partial class SkillBoostBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public static readonly SkillBoostBinaryWriteTranslation Instance = new();

        public static void WriteEmbedded(
            ISkillBoostGetter item,
            MutagenWriter writer)
        {
            EnumBinaryTranslation<ActorValue, MutagenFrame, MutagenWriter>.Instance.Write(
                writer,
                item.Skill,
                length: 1);
            writer.Write(item.Boost);
        }

        public void Write(
            MutagenWriter writer,
            ISkillBoostGetter item,
            TypedWriteParams translationParams)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (ISkillBoostGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class SkillBoostBinaryCreateTranslation
    {
        public static readonly SkillBoostBinaryCreateTranslation Instance = new SkillBoostBinaryCreateTranslation();

        public static void FillBinaryStructs(
            ISkillBoost item,
            MutagenFrame frame)
        {
            item.Skill = EnumBinaryTranslation<ActorValue, MutagenFrame, MutagenWriter>.Instance.Parse(
                reader: frame,
                length: 1);
            item.Boost = frame.ReadInt8();
        }

    }

}
namespace Mutagen.Bethesda.Oblivion
{
    #region Binary Write Mixins
    public static class SkillBoostBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this ISkillBoostGetter item,
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((SkillBoostBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                translationParams: translationParams);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Oblivion
{
    internal partial class SkillBoostBinaryOverlay :
        PluginBinaryOverlay,
        ISkillBoostGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => SkillBoost_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => SkillBoost_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => SkillBoostCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => SkillBoostSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object ISkillBoostGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? ISkillBoostGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object ISkillBoostGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => SkillBoostBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((SkillBoostBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        public ActorValue Skill => (ActorValue)_structData.Span.Slice(0x0, 0x1)[0];
        public SByte Boost => (sbyte)_structData.Slice(0x1, 0x1)[0];
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected SkillBoostBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }

        public static ISkillBoostGetter SkillBoostFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            stream = ExtractTypelessSubrecordStructMemory(
                stream: stream,
                meta: package.MetaData.Constants,
                translationParams: translationParams,
                length: 0x2,
                memoryPair: out var memoryPair,
                offset: out var offset);
            var ret = new SkillBoostBinaryOverlay(
                memoryPair: memoryPair,
                package: package);
            stream.Position += 0x2;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static ISkillBoostGetter SkillBoostFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            return SkillBoostFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            SkillBoostMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not ISkillBoostGetter rhs) return false;
            return ((SkillBoostCommon)((ISkillBoostGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(ISkillBoostGetter? obj)
        {
            return ((SkillBoostCommon)((ISkillBoostGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((SkillBoostCommon)((ISkillBoostGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

