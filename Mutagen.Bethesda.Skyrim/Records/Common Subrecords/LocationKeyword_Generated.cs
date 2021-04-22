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
    public partial class LocationKeyword :
        ALocationTarget,
        IEquatable<ILocationKeywordGetter>,
        ILocationKeyword,
        ILoquiObjectSetter<LocationKeyword>
    {
        #region Ctor
        public LocationKeyword()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Link
        private IFormLink<IKeywordGetter> _Link = new FormLink<IKeywordGetter>();
        public IFormLink<IKeywordGetter> Link
        {
            get => _Link;
            set => _Link = value.AsSetter();
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IFormLinkGetter<IKeywordGetter> ILocationKeywordGetter.Link => this.Link;
        #endregion

        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            LocationKeywordMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not ILocationKeywordGetter rhs) return false;
            return ((LocationKeywordCommon)((ILocationKeywordGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(ILocationKeywordGetter? obj)
        {
            return ((LocationKeywordCommon)((ILocationKeywordGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((LocationKeywordCommon)((ILocationKeywordGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            ALocationTarget.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem Link)
            : base()
            {
                this.Link = Link;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Link;
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
                if (!object.Equals(this.Link, rhs.Link)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Link);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.Link)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.Link)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new LocationKeyword.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.Link = eval(this.Link);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(LocationKeyword.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, LocationKeyword.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(LocationKeyword.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.Link ?? true)
                    {
                        fg.AppendItem(Link, "Link");
                    }
                }
                fg.AppendLine("]");
            }
            #endregion

        }

        public new class ErrorMask :
            ALocationTarget.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Link;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                LocationKeyword_FieldIndex enu = (LocationKeyword_FieldIndex)index;
                switch (enu)
                {
                    case LocationKeyword_FieldIndex.Link:
                        return Link;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                LocationKeyword_FieldIndex enu = (LocationKeyword_FieldIndex)index;
                switch (enu)
                {
                    case LocationKeyword_FieldIndex.Link:
                        this.Link = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                LocationKeyword_FieldIndex enu = (LocationKeyword_FieldIndex)index;
                switch (enu)
                {
                    case LocationKeyword_FieldIndex.Link:
                        this.Link = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (Link != null) return true;
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
                fg.AppendItem(Link, "Link");
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Link = this.Link.Combine(rhs.Link);
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
            ALocationTarget.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool Link;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
                this.Link = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((Link, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Mutagen
        public override IEnumerable<FormLinkInformation> ContainedFormLinks => LocationKeywordCommon.Instance.GetContainedFormLinks(this);
        public override void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => LocationKeywordSetterCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => LocationKeywordBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((LocationKeywordBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #region Binary Create
        public new static LocationKeyword CreateFromBinary(
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new LocationKeyword();
            ((LocationKeywordSetterCommon)((ILocationKeywordGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out LocationKeyword item,
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
            ((LocationKeywordSetterCommon)((ILocationKeywordGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new LocationKeyword GetNew()
        {
            return new LocationKeyword();
        }

    }
    #endregion

    #region Interface
    public partial interface ILocationKeyword :
        IALocationTarget,
        IFormLinkContainer,
        ILocationKeywordGetter,
        ILoquiObjectSetter<ILocationKeyword>
    {
        new IFormLink<IKeywordGetter> Link { get; }
    }

    public partial interface ILocationKeywordGetter :
        IALocationTargetGetter,
        IBinaryItem,
        IFormLinkContainerGetter,
        ILoquiObject<ILocationKeywordGetter>
    {
        static new ILoquiRegistration Registration => LocationKeyword_Registration.Instance;
        IFormLinkGetter<IKeywordGetter> Link { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class LocationKeywordMixIn
    {
        public static void Clear(this ILocationKeyword item)
        {
            ((LocationKeywordSetterCommon)((ILocationKeywordGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static LocationKeyword.Mask<bool> GetEqualsMask(
            this ILocationKeywordGetter item,
            ILocationKeywordGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((LocationKeywordCommon)((ILocationKeywordGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this ILocationKeywordGetter item,
            string? name = null,
            LocationKeyword.Mask<bool>? printMask = null)
        {
            return ((LocationKeywordCommon)((ILocationKeywordGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this ILocationKeywordGetter item,
            FileGeneration fg,
            string? name = null,
            LocationKeyword.Mask<bool>? printMask = null)
        {
            ((LocationKeywordCommon)((ILocationKeywordGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this ILocationKeywordGetter item,
            ILocationKeywordGetter rhs,
            LocationKeyword.TranslationMask? equalsMask = null)
        {
            return ((LocationKeywordCommon)((ILocationKeywordGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this ILocationKeyword lhs,
            ILocationKeywordGetter rhs,
            out LocationKeyword.ErrorMask errorMask,
            LocationKeyword.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((LocationKeywordSetterTranslationCommon)((ILocationKeywordGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = LocationKeyword.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this ILocationKeyword lhs,
            ILocationKeywordGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((LocationKeywordSetterTranslationCommon)((ILocationKeywordGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static LocationKeyword DeepCopy(
            this ILocationKeywordGetter item,
            LocationKeyword.TranslationMask? copyMask = null)
        {
            return ((LocationKeywordSetterTranslationCommon)((ILocationKeywordGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static LocationKeyword DeepCopy(
            this ILocationKeywordGetter item,
            out LocationKeyword.ErrorMask errorMask,
            LocationKeyword.TranslationMask? copyMask = null)
        {
            return ((LocationKeywordSetterTranslationCommon)((ILocationKeywordGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static LocationKeyword DeepCopy(
            this ILocationKeywordGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((LocationKeywordSetterTranslationCommon)((ILocationKeywordGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this ILocationKeyword item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((LocationKeywordSetterCommon)((ILocationKeywordGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    public enum LocationKeyword_FieldIndex
    {
        Link = 0,
    }
    #endregion

    #region Registration
    public partial class LocationKeyword_Registration : ILoquiRegistration
    {
        public static readonly LocationKeyword_Registration Instance = new LocationKeyword_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 232,
            version: 0);

        public const string GUID = "a7c4d6c2-ebb4-4f93-a1e2-c5a9c33bae67";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 1;

        public static readonly Type MaskType = typeof(LocationKeyword.Mask<>);

        public static readonly Type ErrorMaskType = typeof(LocationKeyword.ErrorMask);

        public static readonly Type ClassType = typeof(LocationKeyword);

        public static readonly Type GetterType = typeof(ILocationKeywordGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(ILocationKeyword);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.LocationKeyword";

        public const string Name = "LocationKeyword";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(LocationKeywordBinaryWriteTranslation);
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
    public partial class LocationKeywordSetterCommon : ALocationTargetSetterCommon
    {
        public new static readonly LocationKeywordSetterCommon Instance = new LocationKeywordSetterCommon();

        partial void ClearPartial();
        
        public void Clear(ILocationKeyword item)
        {
            ClearPartial();
            item.Link.Clear();
            base.Clear(item);
        }
        
        public override void Clear(IALocationTarget item)
        {
            Clear(item: (ILocationKeyword)item);
        }
        
        #region Mutagen
        public void RemapLinks(ILocationKeyword obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
            obj.Link.Relink(mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            ILocationKeyword item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter,
                fillStructs: LocationKeywordBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IALocationTarget item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            CopyInFromBinary(
                item: (LocationKeyword)item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }
        
        #endregion
        
    }
    public partial class LocationKeywordCommon : ALocationTargetCommon
    {
        public new static readonly LocationKeywordCommon Instance = new LocationKeywordCommon();

        public LocationKeyword.Mask<bool> GetEqualsMask(
            ILocationKeywordGetter item,
            ILocationKeywordGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new LocationKeyword.Mask<bool>(false);
            ((LocationKeywordCommon)((ILocationKeywordGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            ILocationKeywordGetter item,
            ILocationKeywordGetter rhs,
            LocationKeyword.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Link = item.Link.Equals(rhs.Link);
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string ToString(
            ILocationKeywordGetter item,
            string? name = null,
            LocationKeyword.Mask<bool>? printMask = null)
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
            ILocationKeywordGetter item,
            FileGeneration fg,
            string? name = null,
            LocationKeyword.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"LocationKeyword =>");
            }
            else
            {
                fg.AppendLine($"{name} (LocationKeyword) =>");
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
            ILocationKeywordGetter item,
            FileGeneration fg,
            LocationKeyword.Mask<bool>? printMask = null)
        {
            ALocationTargetCommon.ToStringFields(
                item: item,
                fg: fg,
                printMask: printMask);
            if (printMask?.Link ?? true)
            {
                fg.AppendItem(item.Link.FormKey, "Link");
            }
        }
        
        public static LocationKeyword_FieldIndex ConvertFieldIndex(ALocationTarget_FieldIndex index)
        {
            switch (index)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            ILocationKeywordGetter? lhs,
            ILocationKeywordGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            if (!base.Equals((IALocationTargetGetter)lhs, (IALocationTargetGetter)rhs, crystal)) return false;
            if ((crystal?.GetShouldTranslate((int)LocationKeyword_FieldIndex.Link) ?? true))
            {
                if (!lhs.Link.Equals(rhs.Link)) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IALocationTargetGetter? lhs,
            IALocationTargetGetter? rhs,
            TranslationCrystal? crystal)
        {
            return Equals(
                lhs: (ILocationKeywordGetter?)lhs,
                rhs: rhs as ILocationKeywordGetter,
                crystal: crystal);
        }
        
        public virtual int GetHashCode(ILocationKeywordGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Link);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IALocationTargetGetter item)
        {
            return GetHashCode(item: (ILocationKeywordGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return LocationKeyword.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<FormLinkInformation> GetContainedFormLinks(ILocationKeywordGetter obj)
        {
            foreach (var item in base.GetContainedFormLinks(obj))
            {
                yield return item;
            }
            yield return FormLinkInformation.Factory(obj.Link);
            yield break;
        }
        
        #endregion
        
    }
    public partial class LocationKeywordSetterTranslationCommon : ALocationTargetSetterTranslationCommon
    {
        public new static readonly LocationKeywordSetterTranslationCommon Instance = new LocationKeywordSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            ILocationKeyword item,
            ILocationKeywordGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IALocationTarget)item,
                (IALocationTargetGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)LocationKeyword_FieldIndex.Link) ?? true))
            {
                item.Link.SetTo(rhs.Link.FormKey);
            }
        }
        
        
        public override void DeepCopyIn(
            IALocationTarget item,
            IALocationTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (ILocationKeyword)item,
                rhs: (ILocationKeywordGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public LocationKeyword DeepCopy(
            ILocationKeywordGetter item,
            LocationKeyword.TranslationMask? copyMask = null)
        {
            LocationKeyword ret = (LocationKeyword)((LocationKeywordCommon)((ILocationKeywordGetter)item).CommonInstance()!).GetNew();
            ((LocationKeywordSetterTranslationCommon)((ILocationKeywordGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public LocationKeyword DeepCopy(
            ILocationKeywordGetter item,
            out LocationKeyword.ErrorMask errorMask,
            LocationKeyword.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            LocationKeyword ret = (LocationKeyword)((LocationKeywordCommon)((ILocationKeywordGetter)item).CommonInstance()!).GetNew();
            ((LocationKeywordSetterTranslationCommon)((ILocationKeywordGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = LocationKeyword.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public LocationKeyword DeepCopy(
            ILocationKeywordGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            LocationKeyword ret = (LocationKeyword)((LocationKeywordCommon)((ILocationKeywordGetter)item).CommonInstance()!).GetNew();
            ((LocationKeywordSetterTranslationCommon)((ILocationKeywordGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class LocationKeyword
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => LocationKeyword_Registration.Instance;
        public new static LocationKeyword_Registration Registration => LocationKeyword_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => LocationKeywordCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return LocationKeywordSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => LocationKeywordSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class LocationKeywordBinaryWriteTranslation :
        ALocationTargetBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new readonly static LocationKeywordBinaryWriteTranslation Instance = new LocationKeywordBinaryWriteTranslation();

        public static void WriteEmbedded(
            ILocationKeywordGetter item,
            MutagenWriter writer)
        {
            FormLinkBinaryTranslation.Instance.Write(
                writer: writer,
                item: item.Link);
        }

        public void Write(
            MutagenWriter writer,
            ILocationKeywordGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (ILocationKeywordGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public override void Write(
            MutagenWriter writer,
            IALocationTargetGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (ILocationKeywordGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class LocationKeywordBinaryCreateTranslation : ALocationTargetBinaryCreateTranslation
    {
        public new readonly static LocationKeywordBinaryCreateTranslation Instance = new LocationKeywordBinaryCreateTranslation();

        public static void FillBinaryStructs(
            ILocationKeyword item,
            MutagenFrame frame)
        {
            item.Link.SetTo(FormLinkBinaryTranslation.Instance.Parse(reader: frame));
        }

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class LocationKeywordBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class LocationKeywordBinaryOverlay :
        ALocationTargetBinaryOverlay,
        ILocationKeywordGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => LocationKeyword_Registration.Instance;
        public new static LocationKeyword_Registration Registration => LocationKeyword_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => LocationKeywordCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => LocationKeywordSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        public override IEnumerable<FormLinkInformation> ContainedFormLinks => LocationKeywordCommon.Instance.GetContainedFormLinks(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => LocationKeywordBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((LocationKeywordBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public IFormLinkGetter<IKeywordGetter> Link => new FormLink<IKeywordGetter>(FormKey.Factory(_package.MetaData.MasterReferences!, BinaryPrimitives.ReadUInt32LittleEndian(_data.Span.Slice(0x0, 0x4))));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected LocationKeywordBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static LocationKeywordBinaryOverlay LocationKeywordFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new LocationKeywordBinaryOverlay(
                bytes: stream.RemainingMemory.Slice(0, 0x4),
                package: package);
            int offset = stream.Position;
            stream.Position += 0x4;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static LocationKeywordBinaryOverlay LocationKeywordFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            return LocationKeywordFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                recordTypeConverter: recordTypeConverter);
        }

        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            LocationKeywordMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not ILocationKeywordGetter rhs) return false;
            return ((LocationKeywordCommon)((ILocationKeywordGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(ILocationKeywordGetter? obj)
        {
            return ((LocationKeywordCommon)((ILocationKeywordGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((LocationKeywordCommon)((ILocationKeywordGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

