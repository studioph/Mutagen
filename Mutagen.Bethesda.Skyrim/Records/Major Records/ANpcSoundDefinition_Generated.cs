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
    /// <summary>
    /// Implemented by: [NpcInheritSound, NpcSoundTypes]
    /// </summary>
    public abstract partial class ANpcSoundDefinition :
        IANpcSoundDefinition,
        IEquatable<IANpcSoundDefinitionGetter>,
        ILoquiObjectSetter<ANpcSoundDefinition>
    {
        #region Ctor
        public ANpcSoundDefinition()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion


        #region To String

        public virtual void ToString(
            FileGeneration fg,
            string? name = null)
        {
            ANpcSoundDefinitionMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IANpcSoundDefinitionGetter rhs) return false;
            return ((ANpcSoundDefinitionCommon)((IANpcSoundDefinitionGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IANpcSoundDefinitionGetter? obj)
        {
            return ((ANpcSoundDefinitionCommon)((IANpcSoundDefinitionGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((ANpcSoundDefinitionCommon)((IANpcSoundDefinitionGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
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
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public virtual bool All(Func<TItem, bool> eval)
            {
                return true;
            }
            #endregion

            #region Any
            public virtual bool Any(Func<TItem, bool> eval)
            {
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new ANpcSoundDefinition.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(ANpcSoundDefinition.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, ANpcSoundDefinition.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(ANpcSoundDefinition.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                }
                fg.AppendLine("]");
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
            #endregion

            #region IErrorMask
            public virtual object? GetNthMask(int index)
            {
                ANpcSoundDefinition_FieldIndex enu = (ANpcSoundDefinition_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual void SetNthException(int index, Exception ex)
            {
                ANpcSoundDefinition_FieldIndex enu = (ANpcSoundDefinition_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual void SetNthMask(int index, object obj)
            {
                ANpcSoundDefinition_FieldIndex enu = (ANpcSoundDefinition_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual bool IsInError()
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

            public virtual void ToString(FileGeneration fg, string? name = null)
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
            protected virtual void ToString_FillInternal(FileGeneration fg)
            {
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
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
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

            protected virtual void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Mutagen
        public virtual IEnumerable<FormLinkInformation> ContainedFormLinks => ANpcSoundDefinitionCommon.Instance.GetContainedFormLinks(this);
        public virtual void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => ANpcSoundDefinitionSetterCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected virtual object BinaryWriteTranslator => ANpcSoundDefinitionBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ANpcSoundDefinitionBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((ANpcSoundDefinitionSetterCommon)((IANpcSoundDefinitionGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static ANpcSoundDefinition GetNew()
        {
            throw new ArgumentException("New called on an abstract class.");
        }

    }
    #endregion

    #region Interface
    /// <summary>
    /// Implemented by: [NpcInheritSound, NpcSoundTypes]
    /// </summary>
    public partial interface IANpcSoundDefinition :
        IANpcSoundDefinitionGetter,
        IFormLinkContainer,
        ILoquiObjectSetter<IANpcSoundDefinition>
    {
    }

    /// <summary>
    /// Implemented by: [NpcInheritSound, NpcSoundTypes]
    /// </summary>
    public partial interface IANpcSoundDefinitionGetter :
        ILoquiObject,
        IBinaryItem,
        IFormLinkContainerGetter,
        ILoquiObject<IANpcSoundDefinitionGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration Registration => ANpcSoundDefinition_Registration.Instance;

    }

    #endregion

    #region Common MixIn
    public static partial class ANpcSoundDefinitionMixIn
    {
        public static void Clear(this IANpcSoundDefinition item)
        {
            ((ANpcSoundDefinitionSetterCommon)((IANpcSoundDefinitionGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static ANpcSoundDefinition.Mask<bool> GetEqualsMask(
            this IANpcSoundDefinitionGetter item,
            IANpcSoundDefinitionGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((ANpcSoundDefinitionCommon)((IANpcSoundDefinitionGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IANpcSoundDefinitionGetter item,
            string? name = null,
            ANpcSoundDefinition.Mask<bool>? printMask = null)
        {
            return ((ANpcSoundDefinitionCommon)((IANpcSoundDefinitionGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IANpcSoundDefinitionGetter item,
            FileGeneration fg,
            string? name = null,
            ANpcSoundDefinition.Mask<bool>? printMask = null)
        {
            ((ANpcSoundDefinitionCommon)((IANpcSoundDefinitionGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IANpcSoundDefinitionGetter item,
            IANpcSoundDefinitionGetter rhs,
            ANpcSoundDefinition.TranslationMask? equalsMask = null)
        {
            return ((ANpcSoundDefinitionCommon)((IANpcSoundDefinitionGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IANpcSoundDefinition lhs,
            IANpcSoundDefinitionGetter rhs)
        {
            ((ANpcSoundDefinitionSetterTranslationCommon)((IANpcSoundDefinitionGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IANpcSoundDefinition lhs,
            IANpcSoundDefinitionGetter rhs,
            ANpcSoundDefinition.TranslationMask? copyMask = null)
        {
            ((ANpcSoundDefinitionSetterTranslationCommon)((IANpcSoundDefinitionGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IANpcSoundDefinition lhs,
            IANpcSoundDefinitionGetter rhs,
            out ANpcSoundDefinition.ErrorMask errorMask,
            ANpcSoundDefinition.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((ANpcSoundDefinitionSetterTranslationCommon)((IANpcSoundDefinitionGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = ANpcSoundDefinition.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IANpcSoundDefinition lhs,
            IANpcSoundDefinitionGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((ANpcSoundDefinitionSetterTranslationCommon)((IANpcSoundDefinitionGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static ANpcSoundDefinition DeepCopy(
            this IANpcSoundDefinitionGetter item,
            ANpcSoundDefinition.TranslationMask? copyMask = null)
        {
            return ((ANpcSoundDefinitionSetterTranslationCommon)((IANpcSoundDefinitionGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static ANpcSoundDefinition DeepCopy(
            this IANpcSoundDefinitionGetter item,
            out ANpcSoundDefinition.ErrorMask errorMask,
            ANpcSoundDefinition.TranslationMask? copyMask = null)
        {
            return ((ANpcSoundDefinitionSetterTranslationCommon)((IANpcSoundDefinitionGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static ANpcSoundDefinition DeepCopy(
            this IANpcSoundDefinitionGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((ANpcSoundDefinitionSetterTranslationCommon)((IANpcSoundDefinitionGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IANpcSoundDefinition item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ANpcSoundDefinitionSetterCommon)((IANpcSoundDefinitionGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    public enum ANpcSoundDefinition_FieldIndex
    {
    }
    #endregion

    #region Registration
    public partial class ANpcSoundDefinition_Registration : ILoquiRegistration
    {
        public static readonly ANpcSoundDefinition_Registration Instance = new ANpcSoundDefinition_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 210,
            version: 0);

        public const string GUID = "fcefa9b8-781d-44ea-b623-abd75e419f5a";

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 0;

        public static readonly Type MaskType = typeof(ANpcSoundDefinition.Mask<>);

        public static readonly Type ErrorMaskType = typeof(ANpcSoundDefinition.ErrorMask);

        public static readonly Type ClassType = typeof(ANpcSoundDefinition);

        public static readonly Type GetterType = typeof(IANpcSoundDefinitionGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IANpcSoundDefinition);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.ANpcSoundDefinition";

        public const string Name = "ANpcSoundDefinition";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static ICollectionGetter<RecordType> TriggeringRecordTypes => _TriggeringRecordTypes.Value;
        private static readonly Lazy<ICollectionGetter<RecordType>> _TriggeringRecordTypes = new Lazy<ICollectionGetter<RecordType>>(() =>
        {
            return new CollectionGetterWrapper<RecordType>(
                new HashSet<RecordType>(
                    new RecordType[]
                    {
                        RecordTypes.CSCR,
                        RecordTypes.CSDT,
                        RecordTypes.CSDI,
                        RecordTypes.CSDC
                    })
            );
        });
        public static readonly Type BinaryWriteTranslation = typeof(ANpcSoundDefinitionBinaryWriteTranslation);
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
    public partial class ANpcSoundDefinitionSetterCommon
    {
        public static readonly ANpcSoundDefinitionSetterCommon Instance = new ANpcSoundDefinitionSetterCommon();

        partial void ClearPartial();
        
        public virtual void Clear(IANpcSoundDefinition item)
        {
            ClearPartial();
        }
        
        #region Mutagen
        public void RemapLinks(IANpcSoundDefinition obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IANpcSoundDefinition item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
        }
        
        #endregion
        
    }
    public partial class ANpcSoundDefinitionCommon
    {
        public static readonly ANpcSoundDefinitionCommon Instance = new ANpcSoundDefinitionCommon();

        public ANpcSoundDefinition.Mask<bool> GetEqualsMask(
            IANpcSoundDefinitionGetter item,
            IANpcSoundDefinitionGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new ANpcSoundDefinition.Mask<bool>(false);
            ((ANpcSoundDefinitionCommon)((IANpcSoundDefinitionGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IANpcSoundDefinitionGetter item,
            IANpcSoundDefinitionGetter rhs,
            ANpcSoundDefinition.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
        }
        
        public string ToString(
            IANpcSoundDefinitionGetter item,
            string? name = null,
            ANpcSoundDefinition.Mask<bool>? printMask = null)
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
            IANpcSoundDefinitionGetter item,
            FileGeneration fg,
            string? name = null,
            ANpcSoundDefinition.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"ANpcSoundDefinition =>");
            }
            else
            {
                fg.AppendLine($"{name} (ANpcSoundDefinition) =>");
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
            IANpcSoundDefinitionGetter item,
            FileGeneration fg,
            ANpcSoundDefinition.Mask<bool>? printMask = null)
        {
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IANpcSoundDefinitionGetter? lhs,
            IANpcSoundDefinitionGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            return true;
        }
        
        public virtual int GetHashCode(IANpcSoundDefinitionGetter item)
        {
            var hash = new HashCode();
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public virtual object GetNew()
        {
            return ANpcSoundDefinition.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<FormLinkInformation> GetContainedFormLinks(IANpcSoundDefinitionGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    public partial class ANpcSoundDefinitionSetterTranslationCommon
    {
        public static readonly ANpcSoundDefinitionSetterTranslationCommon Instance = new ANpcSoundDefinitionSetterTranslationCommon();

        #region DeepCopyIn
        public virtual void DeepCopyIn(
            IANpcSoundDefinition item,
            IANpcSoundDefinitionGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
        }
        
        #endregion
        
        public ANpcSoundDefinition DeepCopy(
            IANpcSoundDefinitionGetter item,
            ANpcSoundDefinition.TranslationMask? copyMask = null)
        {
            ANpcSoundDefinition ret = (ANpcSoundDefinition)((ANpcSoundDefinitionCommon)((IANpcSoundDefinitionGetter)item).CommonInstance()!).GetNew();
            ((ANpcSoundDefinitionSetterTranslationCommon)((IANpcSoundDefinitionGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public ANpcSoundDefinition DeepCopy(
            IANpcSoundDefinitionGetter item,
            out ANpcSoundDefinition.ErrorMask errorMask,
            ANpcSoundDefinition.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ANpcSoundDefinition ret = (ANpcSoundDefinition)((ANpcSoundDefinitionCommon)((IANpcSoundDefinitionGetter)item).CommonInstance()!).GetNew();
            ((ANpcSoundDefinitionSetterTranslationCommon)((IANpcSoundDefinitionGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = ANpcSoundDefinition.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public ANpcSoundDefinition DeepCopy(
            IANpcSoundDefinitionGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            ANpcSoundDefinition ret = (ANpcSoundDefinition)((ANpcSoundDefinitionCommon)((IANpcSoundDefinitionGetter)item).CommonInstance()!).GetNew();
            ((ANpcSoundDefinitionSetterTranslationCommon)((IANpcSoundDefinitionGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class ANpcSoundDefinition
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ANpcSoundDefinition_Registration.Instance;
        public static ANpcSoundDefinition_Registration Registration => ANpcSoundDefinition_Registration.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonInstance() => ANpcSoundDefinitionCommon.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonSetterInstance()
        {
            return ANpcSoundDefinitionSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected virtual object CommonSetterTranslationInstance() => ANpcSoundDefinitionSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IANpcSoundDefinitionGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IANpcSoundDefinitionGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IANpcSoundDefinitionGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class ANpcSoundDefinitionBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public readonly static ANpcSoundDefinitionBinaryWriteTranslation Instance = new ANpcSoundDefinitionBinaryWriteTranslation();

        public virtual void Write(
            MutagenWriter writer,
            IANpcSoundDefinitionGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
        }

        public virtual void Write(
            MutagenWriter writer,
            object item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IANpcSoundDefinitionGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class ANpcSoundDefinitionBinaryCreateTranslation
    {
        public readonly static ANpcSoundDefinitionBinaryCreateTranslation Instance = new ANpcSoundDefinitionBinaryCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class ANpcSoundDefinitionBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this IANpcSoundDefinitionGetter item,
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ANpcSoundDefinitionBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class ANpcSoundDefinitionBinaryOverlay :
        PluginBinaryOverlay,
        IANpcSoundDefinitionGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ANpcSoundDefinition_Registration.Instance;
        public static ANpcSoundDefinition_Registration Registration => ANpcSoundDefinition_Registration.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonInstance() => ANpcSoundDefinitionCommon.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonSetterTranslationInstance() => ANpcSoundDefinitionSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IANpcSoundDefinitionGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? IANpcSoundDefinitionGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object IANpcSoundDefinitionGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        public virtual IEnumerable<FormLinkInformation> ContainedFormLinks => ANpcSoundDefinitionCommon.Instance.GetContainedFormLinks(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected virtual object BinaryWriteTranslator => ANpcSoundDefinitionBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ANpcSoundDefinitionBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected ANpcSoundDefinitionBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }


        #region To String

        public virtual void ToString(
            FileGeneration fg,
            string? name = null)
        {
            ANpcSoundDefinitionMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IANpcSoundDefinitionGetter rhs) return false;
            return ((ANpcSoundDefinitionCommon)((IANpcSoundDefinitionGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IANpcSoundDefinitionGetter? obj)
        {
            return ((ANpcSoundDefinitionCommon)((IANpcSoundDefinitionGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((ANpcSoundDefinitionCommon)((IANpcSoundDefinitionGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

