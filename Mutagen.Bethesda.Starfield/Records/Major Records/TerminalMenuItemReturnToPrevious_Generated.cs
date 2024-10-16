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
    public partial class TerminalMenuItemReturnToPrevious :
        ATerminalMenuItemTarget,
        IEquatable<ITerminalMenuItemReturnToPreviousGetter>,
        ILoquiObjectSetter<TerminalMenuItemReturnToPrevious>,
        ITerminalMenuItemReturnToPrevious
    {
        #region Ctor
        public TerminalMenuItemReturnToPrevious()
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
            TerminalMenuItemReturnToPreviousMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not ITerminalMenuItemReturnToPreviousGetter rhs) return false;
            return ((TerminalMenuItemReturnToPreviousCommon)((ITerminalMenuItemReturnToPreviousGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(ITerminalMenuItemReturnToPreviousGetter? obj)
        {
            return ((TerminalMenuItemReturnToPreviousCommon)((ITerminalMenuItemReturnToPreviousGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((TerminalMenuItemReturnToPreviousCommon)((ITerminalMenuItemReturnToPreviousGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            ATerminalMenuItemTarget.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
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
                var ret = new TerminalMenuItemReturnToPrevious.Mask<R>();
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

            public string Print(TerminalMenuItemReturnToPrevious.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, TerminalMenuItemReturnToPrevious.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(TerminalMenuItemReturnToPrevious.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                }
            }
            #endregion

        }

        public new class ErrorMask :
            ATerminalMenuItemTarget.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                TerminalMenuItemReturnToPrevious_FieldIndex enu = (TerminalMenuItemReturnToPrevious_FieldIndex)index;
                switch (enu)
                {
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                TerminalMenuItemReturnToPrevious_FieldIndex enu = (TerminalMenuItemReturnToPrevious_FieldIndex)index;
                switch (enu)
                {
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                TerminalMenuItemReturnToPrevious_FieldIndex enu = (TerminalMenuItemReturnToPrevious_FieldIndex)index;
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
            ATerminalMenuItemTarget.TranslationMask,
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
        protected override object BinaryWriteTranslator => TerminalMenuItemReturnToPreviousBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((TerminalMenuItemReturnToPreviousBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static TerminalMenuItemReturnToPrevious CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new TerminalMenuItemReturnToPrevious();
            ((TerminalMenuItemReturnToPreviousSetterCommon)((ITerminalMenuItemReturnToPreviousGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out TerminalMenuItemReturnToPrevious item,
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
            ((TerminalMenuItemReturnToPreviousSetterCommon)((ITerminalMenuItemReturnToPreviousGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new TerminalMenuItemReturnToPrevious GetNew()
        {
            return new TerminalMenuItemReturnToPrevious();
        }

    }
    #endregion

    #region Interface
    public partial interface ITerminalMenuItemReturnToPrevious :
        IATerminalMenuItemTarget,
        ILoquiObjectSetter<ITerminalMenuItemReturnToPrevious>,
        ITerminalMenuItemReturnToPreviousGetter
    {
    }

    public partial interface ITerminalMenuItemReturnToPreviousGetter :
        IATerminalMenuItemTargetGetter,
        IBinaryItem,
        ILoquiObject<ITerminalMenuItemReturnToPreviousGetter>
    {
        static new ILoquiRegistration StaticRegistration => TerminalMenuItemReturnToPrevious_Registration.Instance;

    }

    #endregion

    #region Common MixIn
    public static partial class TerminalMenuItemReturnToPreviousMixIn
    {
        public static void Clear(this ITerminalMenuItemReturnToPrevious item)
        {
            ((TerminalMenuItemReturnToPreviousSetterCommon)((ITerminalMenuItemReturnToPreviousGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static TerminalMenuItemReturnToPrevious.Mask<bool> GetEqualsMask(
            this ITerminalMenuItemReturnToPreviousGetter item,
            ITerminalMenuItemReturnToPreviousGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((TerminalMenuItemReturnToPreviousCommon)((ITerminalMenuItemReturnToPreviousGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this ITerminalMenuItemReturnToPreviousGetter item,
            string? name = null,
            TerminalMenuItemReturnToPrevious.Mask<bool>? printMask = null)
        {
            return ((TerminalMenuItemReturnToPreviousCommon)((ITerminalMenuItemReturnToPreviousGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this ITerminalMenuItemReturnToPreviousGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            TerminalMenuItemReturnToPrevious.Mask<bool>? printMask = null)
        {
            ((TerminalMenuItemReturnToPreviousCommon)((ITerminalMenuItemReturnToPreviousGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this ITerminalMenuItemReturnToPreviousGetter item,
            ITerminalMenuItemReturnToPreviousGetter rhs,
            TerminalMenuItemReturnToPrevious.TranslationMask? equalsMask = null)
        {
            return ((TerminalMenuItemReturnToPreviousCommon)((ITerminalMenuItemReturnToPreviousGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                equalsMask: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this ITerminalMenuItemReturnToPrevious lhs,
            ITerminalMenuItemReturnToPreviousGetter rhs,
            out TerminalMenuItemReturnToPrevious.ErrorMask errorMask,
            TerminalMenuItemReturnToPrevious.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((TerminalMenuItemReturnToPreviousSetterTranslationCommon)((ITerminalMenuItemReturnToPreviousGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = TerminalMenuItemReturnToPrevious.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this ITerminalMenuItemReturnToPrevious lhs,
            ITerminalMenuItemReturnToPreviousGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((TerminalMenuItemReturnToPreviousSetterTranslationCommon)((ITerminalMenuItemReturnToPreviousGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static TerminalMenuItemReturnToPrevious DeepCopy(
            this ITerminalMenuItemReturnToPreviousGetter item,
            TerminalMenuItemReturnToPrevious.TranslationMask? copyMask = null)
        {
            return ((TerminalMenuItemReturnToPreviousSetterTranslationCommon)((ITerminalMenuItemReturnToPreviousGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static TerminalMenuItemReturnToPrevious DeepCopy(
            this ITerminalMenuItemReturnToPreviousGetter item,
            out TerminalMenuItemReturnToPrevious.ErrorMask errorMask,
            TerminalMenuItemReturnToPrevious.TranslationMask? copyMask = null)
        {
            return ((TerminalMenuItemReturnToPreviousSetterTranslationCommon)((ITerminalMenuItemReturnToPreviousGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static TerminalMenuItemReturnToPrevious DeepCopy(
            this ITerminalMenuItemReturnToPreviousGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((TerminalMenuItemReturnToPreviousSetterTranslationCommon)((ITerminalMenuItemReturnToPreviousGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this ITerminalMenuItemReturnToPrevious item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((TerminalMenuItemReturnToPreviousSetterCommon)((ITerminalMenuItemReturnToPreviousGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    internal enum TerminalMenuItemReturnToPrevious_FieldIndex
    {
    }
    #endregion

    #region Registration
    internal partial class TerminalMenuItemReturnToPrevious_Registration : ILoquiRegistration
    {
        public static readonly TerminalMenuItemReturnToPrevious_Registration Instance = new TerminalMenuItemReturnToPrevious_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Starfield.ProtocolKey;

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 0;

        public static readonly Type MaskType = typeof(TerminalMenuItemReturnToPrevious.Mask<>);

        public static readonly Type ErrorMaskType = typeof(TerminalMenuItemReturnToPrevious.ErrorMask);

        public static readonly Type ClassType = typeof(TerminalMenuItemReturnToPrevious);

        public static readonly Type GetterType = typeof(ITerminalMenuItemReturnToPreviousGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(ITerminalMenuItemReturnToPrevious);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Starfield.TerminalMenuItemReturnToPrevious";

        public const string Name = "TerminalMenuItemReturnToPrevious";

        public const string Namespace = "Mutagen.Bethesda.Starfield";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(TerminalMenuItemReturnToPreviousBinaryWriteTranslation);
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
    internal partial class TerminalMenuItemReturnToPreviousSetterCommon : ATerminalMenuItemTargetSetterCommon
    {
        public new static readonly TerminalMenuItemReturnToPreviousSetterCommon Instance = new TerminalMenuItemReturnToPreviousSetterCommon();

        partial void ClearPartial();
        
        public void Clear(ITerminalMenuItemReturnToPrevious item)
        {
            ClearPartial();
            base.Clear(item);
        }
        
        public override void Clear(IATerminalMenuItemTarget item)
        {
            Clear(item: (ITerminalMenuItemReturnToPrevious)item);
        }
        
        #region Mutagen
        public void RemapLinks(ITerminalMenuItemReturnToPrevious obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            ITerminalMenuItemReturnToPrevious item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
        }
        
        public override void CopyInFromBinary(
            IATerminalMenuItemTarget item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            CopyInFromBinary(
                item: (TerminalMenuItemReturnToPrevious)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class TerminalMenuItemReturnToPreviousCommon : ATerminalMenuItemTargetCommon
    {
        public new static readonly TerminalMenuItemReturnToPreviousCommon Instance = new TerminalMenuItemReturnToPreviousCommon();

        public TerminalMenuItemReturnToPrevious.Mask<bool> GetEqualsMask(
            ITerminalMenuItemReturnToPreviousGetter item,
            ITerminalMenuItemReturnToPreviousGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new TerminalMenuItemReturnToPrevious.Mask<bool>(false);
            ((TerminalMenuItemReturnToPreviousCommon)((ITerminalMenuItemReturnToPreviousGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            ITerminalMenuItemReturnToPreviousGetter item,
            ITerminalMenuItemReturnToPreviousGetter rhs,
            TerminalMenuItemReturnToPrevious.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            ITerminalMenuItemReturnToPreviousGetter item,
            string? name = null,
            TerminalMenuItemReturnToPrevious.Mask<bool>? printMask = null)
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
            ITerminalMenuItemReturnToPreviousGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            TerminalMenuItemReturnToPrevious.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"TerminalMenuItemReturnToPrevious =>");
            }
            else
            {
                sb.AppendLine($"{name} (TerminalMenuItemReturnToPrevious) =>");
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
            ITerminalMenuItemReturnToPreviousGetter item,
            StructuredStringBuilder sb,
            TerminalMenuItemReturnToPrevious.Mask<bool>? printMask = null)
        {
            ATerminalMenuItemTargetCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
        }
        
        public static TerminalMenuItemReturnToPrevious_FieldIndex ConvertFieldIndex(ATerminalMenuItemTarget_FieldIndex index)
        {
            switch (index)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            ITerminalMenuItemReturnToPreviousGetter? lhs,
            ITerminalMenuItemReturnToPreviousGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IATerminalMenuItemTargetGetter)lhs, (IATerminalMenuItemTargetGetter)rhs, equalsMask)) return false;
            return true;
        }
        
        public override bool Equals(
            IATerminalMenuItemTargetGetter? lhs,
            IATerminalMenuItemTargetGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            return Equals(
                lhs: (ITerminalMenuItemReturnToPreviousGetter?)lhs,
                rhs: rhs as ITerminalMenuItemReturnToPreviousGetter,
                equalsMask: equalsMask);
        }
        
        public virtual int GetHashCode(ITerminalMenuItemReturnToPreviousGetter item)
        {
            var hash = new HashCode();
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IATerminalMenuItemTargetGetter item)
        {
            return GetHashCode(item: (ITerminalMenuItemReturnToPreviousGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return TerminalMenuItemReturnToPrevious.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(ITerminalMenuItemReturnToPreviousGetter obj)
        {
            foreach (var item in base.EnumerateFormLinks(obj))
            {
                yield return item;
            }
            yield break;
        }
        
        #endregion
        
    }
    internal partial class TerminalMenuItemReturnToPreviousSetterTranslationCommon : ATerminalMenuItemTargetSetterTranslationCommon
    {
        public new static readonly TerminalMenuItemReturnToPreviousSetterTranslationCommon Instance = new TerminalMenuItemReturnToPreviousSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            ITerminalMenuItemReturnToPrevious item,
            ITerminalMenuItemReturnToPreviousGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IATerminalMenuItemTarget)item,
                (IATerminalMenuItemTargetGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            DeepCopyInCustom(
                item: item,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        partial void DeepCopyInCustom(
            ITerminalMenuItemReturnToPrevious item,
            ITerminalMenuItemReturnToPreviousGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy);
        
        public override void DeepCopyIn(
            IATerminalMenuItemTarget item,
            IATerminalMenuItemTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (ITerminalMenuItemReturnToPrevious)item,
                rhs: (ITerminalMenuItemReturnToPreviousGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public TerminalMenuItemReturnToPrevious DeepCopy(
            ITerminalMenuItemReturnToPreviousGetter item,
            TerminalMenuItemReturnToPrevious.TranslationMask? copyMask = null)
        {
            TerminalMenuItemReturnToPrevious ret = (TerminalMenuItemReturnToPrevious)((TerminalMenuItemReturnToPreviousCommon)((ITerminalMenuItemReturnToPreviousGetter)item).CommonInstance()!).GetNew();
            ((TerminalMenuItemReturnToPreviousSetterTranslationCommon)((ITerminalMenuItemReturnToPreviousGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public TerminalMenuItemReturnToPrevious DeepCopy(
            ITerminalMenuItemReturnToPreviousGetter item,
            out TerminalMenuItemReturnToPrevious.ErrorMask errorMask,
            TerminalMenuItemReturnToPrevious.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            TerminalMenuItemReturnToPrevious ret = (TerminalMenuItemReturnToPrevious)((TerminalMenuItemReturnToPreviousCommon)((ITerminalMenuItemReturnToPreviousGetter)item).CommonInstance()!).GetNew();
            ((TerminalMenuItemReturnToPreviousSetterTranslationCommon)((ITerminalMenuItemReturnToPreviousGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = TerminalMenuItemReturnToPrevious.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public TerminalMenuItemReturnToPrevious DeepCopy(
            ITerminalMenuItemReturnToPreviousGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            TerminalMenuItemReturnToPrevious ret = (TerminalMenuItemReturnToPrevious)((TerminalMenuItemReturnToPreviousCommon)((ITerminalMenuItemReturnToPreviousGetter)item).CommonInstance()!).GetNew();
            ((TerminalMenuItemReturnToPreviousSetterTranslationCommon)((ITerminalMenuItemReturnToPreviousGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class TerminalMenuItemReturnToPrevious
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => TerminalMenuItemReturnToPrevious_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => TerminalMenuItemReturnToPrevious_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => TerminalMenuItemReturnToPreviousCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return TerminalMenuItemReturnToPreviousSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => TerminalMenuItemReturnToPreviousSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Starfield
{
    public partial class TerminalMenuItemReturnToPreviousBinaryWriteTranslation :
        ATerminalMenuItemTargetBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new static readonly TerminalMenuItemReturnToPreviousBinaryWriteTranslation Instance = new();

        public void Write(
            MutagenWriter writer,
            ITerminalMenuItemReturnToPreviousGetter item,
            TypedWriteParams translationParams)
        {
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (ITerminalMenuItemReturnToPreviousGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IATerminalMenuItemTargetGetter item,
            TypedWriteParams translationParams)
        {
            Write(
                item: (ITerminalMenuItemReturnToPreviousGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class TerminalMenuItemReturnToPreviousBinaryCreateTranslation : ATerminalMenuItemTargetBinaryCreateTranslation
    {
        public new static readonly TerminalMenuItemReturnToPreviousBinaryCreateTranslation Instance = new TerminalMenuItemReturnToPreviousBinaryCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Starfield
{
    #region Binary Write Mixins
    public static class TerminalMenuItemReturnToPreviousBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Starfield
{
    internal partial class TerminalMenuItemReturnToPreviousBinaryOverlay :
        ATerminalMenuItemTargetBinaryOverlay,
        ITerminalMenuItemReturnToPreviousGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => TerminalMenuItemReturnToPrevious_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => TerminalMenuItemReturnToPrevious_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => TerminalMenuItemReturnToPreviousCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => TerminalMenuItemReturnToPreviousSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => TerminalMenuItemReturnToPreviousBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((TerminalMenuItemReturnToPreviousBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected TerminalMenuItemReturnToPreviousBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }

        public static ITerminalMenuItemReturnToPreviousGetter TerminalMenuItemReturnToPreviousFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            stream = ExtractTypelessSubrecordStructMemory(
                stream: stream,
                meta: package.MetaData.Constants,
                translationParams: translationParams,
                memoryPair: out var memoryPair,
                offset: out var offset,
                finalPos: out var finalPos);
            var ret = new TerminalMenuItemReturnToPreviousBinaryOverlay(
                memoryPair: memoryPair,
                package: package);
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static ITerminalMenuItemReturnToPreviousGetter TerminalMenuItemReturnToPreviousFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            return TerminalMenuItemReturnToPreviousFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            TerminalMenuItemReturnToPreviousMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not ITerminalMenuItemReturnToPreviousGetter rhs) return false;
            return ((TerminalMenuItemReturnToPreviousCommon)((ITerminalMenuItemReturnToPreviousGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(ITerminalMenuItemReturnToPreviousGetter? obj)
        {
            return ((TerminalMenuItemReturnToPreviousCommon)((ITerminalMenuItemReturnToPreviousGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((TerminalMenuItemReturnToPreviousCommon)((ITerminalMenuItemReturnToPreviousGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

