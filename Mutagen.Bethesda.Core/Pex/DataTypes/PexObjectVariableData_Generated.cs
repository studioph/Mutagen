/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Internal;
using Mutagen.Bethesda.Pex.Internals;
using Noggog;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Pex
{
    #region Class
    public partial class PexObjectVariableData :
        IEquatable<IPexObjectVariableDataGetter>,
        ILoquiObjectSetter<PexObjectVariableData>,
        IPexObjectVariableData
    {
        #region Ctor
        public PexObjectVariableData()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region VariableType
        public VariableType VariableType { get; set; } = default;
        #endregion
        #region StringValue
        public String? StringValue { get; set; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        String? IPexObjectVariableDataGetter.StringValue => this.StringValue;
        #endregion
        #region IntValue
        public Int32? IntValue { get; set; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Int32? IPexObjectVariableDataGetter.IntValue => this.IntValue;
        #endregion
        #region FloatValue
        public Single? FloatValue { get; set; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Single? IPexObjectVariableDataGetter.FloatValue => this.FloatValue;
        #endregion
        #region BoolValue
        public Boolean? BoolValue { get; set; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Boolean? IPexObjectVariableDataGetter.BoolValue => this.BoolValue;
        #endregion

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            PexObjectVariableDataMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IPexObjectVariableDataGetter rhs) return false;
            return ((PexObjectVariableDataCommon)((IPexObjectVariableDataGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IPexObjectVariableDataGetter? obj)
        {
            return ((PexObjectVariableDataCommon)((IPexObjectVariableDataGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((PexObjectVariableDataCommon)((IPexObjectVariableDataGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
                this.VariableType = initialValue;
                this.StringValue = initialValue;
                this.IntValue = initialValue;
                this.FloatValue = initialValue;
                this.BoolValue = initialValue;
            }

            public Mask(
                TItem VariableType,
                TItem StringValue,
                TItem IntValue,
                TItem FloatValue,
                TItem BoolValue)
            {
                this.VariableType = VariableType;
                this.StringValue = StringValue;
                this.IntValue = IntValue;
                this.FloatValue = FloatValue;
                this.BoolValue = BoolValue;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem VariableType;
            public TItem StringValue;
            public TItem IntValue;
            public TItem FloatValue;
            public TItem BoolValue;
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
                if (!object.Equals(this.VariableType, rhs.VariableType)) return false;
                if (!object.Equals(this.StringValue, rhs.StringValue)) return false;
                if (!object.Equals(this.IntValue, rhs.IntValue)) return false;
                if (!object.Equals(this.FloatValue, rhs.FloatValue)) return false;
                if (!object.Equals(this.BoolValue, rhs.BoolValue)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.VariableType);
                hash.Add(this.StringValue);
                hash.Add(this.IntValue);
                hash.Add(this.FloatValue);
                hash.Add(this.BoolValue);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.VariableType)) return false;
                if (!eval(this.StringValue)) return false;
                if (!eval(this.IntValue)) return false;
                if (!eval(this.FloatValue)) return false;
                if (!eval(this.BoolValue)) return false;
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.VariableType)) return true;
                if (eval(this.StringValue)) return true;
                if (eval(this.IntValue)) return true;
                if (eval(this.FloatValue)) return true;
                if (eval(this.BoolValue)) return true;
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new PexObjectVariableData.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.VariableType = eval(this.VariableType);
                obj.StringValue = eval(this.StringValue);
                obj.IntValue = eval(this.IntValue);
                obj.FloatValue = eval(this.FloatValue);
                obj.BoolValue = eval(this.BoolValue);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(PexObjectVariableData.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, PexObjectVariableData.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(PexObjectVariableData.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.VariableType ?? true)
                    {
                        fg.AppendItem(VariableType, "VariableType");
                    }
                    if (printMask?.StringValue ?? true)
                    {
                        fg.AppendItem(StringValue, "StringValue");
                    }
                    if (printMask?.IntValue ?? true)
                    {
                        fg.AppendItem(IntValue, "IntValue");
                    }
                    if (printMask?.FloatValue ?? true)
                    {
                        fg.AppendItem(FloatValue, "FloatValue");
                    }
                    if (printMask?.BoolValue ?? true)
                    {
                        fg.AppendItem(BoolValue, "BoolValue");
                    }
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
            public Exception? VariableType;
            public Exception? StringValue;
            public Exception? IntValue;
            public Exception? FloatValue;
            public Exception? BoolValue;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                PexObjectVariableData_FieldIndex enu = (PexObjectVariableData_FieldIndex)index;
                switch (enu)
                {
                    case PexObjectVariableData_FieldIndex.VariableType:
                        return VariableType;
                    case PexObjectVariableData_FieldIndex.StringValue:
                        return StringValue;
                    case PexObjectVariableData_FieldIndex.IntValue:
                        return IntValue;
                    case PexObjectVariableData_FieldIndex.FloatValue:
                        return FloatValue;
                    case PexObjectVariableData_FieldIndex.BoolValue:
                        return BoolValue;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                PexObjectVariableData_FieldIndex enu = (PexObjectVariableData_FieldIndex)index;
                switch (enu)
                {
                    case PexObjectVariableData_FieldIndex.VariableType:
                        this.VariableType = ex;
                        break;
                    case PexObjectVariableData_FieldIndex.StringValue:
                        this.StringValue = ex;
                        break;
                    case PexObjectVariableData_FieldIndex.IntValue:
                        this.IntValue = ex;
                        break;
                    case PexObjectVariableData_FieldIndex.FloatValue:
                        this.FloatValue = ex;
                        break;
                    case PexObjectVariableData_FieldIndex.BoolValue:
                        this.BoolValue = ex;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                PexObjectVariableData_FieldIndex enu = (PexObjectVariableData_FieldIndex)index;
                switch (enu)
                {
                    case PexObjectVariableData_FieldIndex.VariableType:
                        this.VariableType = (Exception?)obj;
                        break;
                    case PexObjectVariableData_FieldIndex.StringValue:
                        this.StringValue = (Exception?)obj;
                        break;
                    case PexObjectVariableData_FieldIndex.IntValue:
                        this.IntValue = (Exception?)obj;
                        break;
                    case PexObjectVariableData_FieldIndex.FloatValue:
                        this.FloatValue = (Exception?)obj;
                        break;
                    case PexObjectVariableData_FieldIndex.BoolValue:
                        this.BoolValue = (Exception?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (VariableType != null) return true;
                if (StringValue != null) return true;
                if (IntValue != null) return true;
                if (FloatValue != null) return true;
                if (BoolValue != null) return true;
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

            public void ToString(FileGeneration fg, string? name = null)
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
            protected void ToString_FillInternal(FileGeneration fg)
            {
                fg.AppendItem(VariableType, "VariableType");
                fg.AppendItem(StringValue, "StringValue");
                fg.AppendItem(IntValue, "IntValue");
                fg.AppendItem(FloatValue, "FloatValue");
                fg.AppendItem(BoolValue, "BoolValue");
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.VariableType = this.VariableType.Combine(rhs.VariableType);
                ret.StringValue = this.StringValue.Combine(rhs.StringValue);
                ret.IntValue = this.IntValue.Combine(rhs.IntValue);
                ret.FloatValue = this.FloatValue.Combine(rhs.FloatValue);
                ret.BoolValue = this.BoolValue.Combine(rhs.BoolValue);
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
            public bool VariableType;
            public bool StringValue;
            public bool IntValue;
            public bool FloatValue;
            public bool BoolValue;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.VariableType = defaultOn;
                this.StringValue = defaultOn;
                this.IntValue = defaultOn;
                this.FloatValue = defaultOn;
                this.BoolValue = defaultOn;
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
                ret.Add((VariableType, null));
                ret.Add((StringValue, null));
                ret.Add((IntValue, null));
                ret.Add((FloatValue, null));
                ret.Add((BoolValue, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((PexObjectVariableDataSetterCommon)((IPexObjectVariableDataGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static PexObjectVariableData GetNew()
        {
            return new PexObjectVariableData();
        }

    }
    #endregion

    #region Interface
    public partial interface IPexObjectVariableData :
        ILoquiObjectSetter<IPexObjectVariableData>,
        IPexObjectVariableDataGetter
    {
        new VariableType VariableType { get; set; }
        new String? StringValue { get; set; }
        new Int32? IntValue { get; set; }
        new Single? FloatValue { get; set; }
        new Boolean? BoolValue { get; set; }
    }

    public partial interface IPexObjectVariableDataGetter :
        ILoquiObject,
        ILoquiObject<IPexObjectVariableDataGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration Registration => PexObjectVariableData_Registration.Instance;
        VariableType VariableType { get; }
        String? StringValue { get; }
        Int32? IntValue { get; }
        Single? FloatValue { get; }
        Boolean? BoolValue { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class PexObjectVariableDataMixIn
    {
        public static void Clear(this IPexObjectVariableData item)
        {
            ((PexObjectVariableDataSetterCommon)((IPexObjectVariableDataGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static PexObjectVariableData.Mask<bool> GetEqualsMask(
            this IPexObjectVariableDataGetter item,
            IPexObjectVariableDataGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((PexObjectVariableDataCommon)((IPexObjectVariableDataGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IPexObjectVariableDataGetter item,
            string? name = null,
            PexObjectVariableData.Mask<bool>? printMask = null)
        {
            return ((PexObjectVariableDataCommon)((IPexObjectVariableDataGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IPexObjectVariableDataGetter item,
            FileGeneration fg,
            string? name = null,
            PexObjectVariableData.Mask<bool>? printMask = null)
        {
            ((PexObjectVariableDataCommon)((IPexObjectVariableDataGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IPexObjectVariableDataGetter item,
            IPexObjectVariableDataGetter rhs,
            PexObjectVariableData.TranslationMask? equalsMask = null)
        {
            return ((PexObjectVariableDataCommon)((IPexObjectVariableDataGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IPexObjectVariableData lhs,
            IPexObjectVariableDataGetter rhs)
        {
            ((PexObjectVariableDataSetterTranslationCommon)((IPexObjectVariableDataGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IPexObjectVariableData lhs,
            IPexObjectVariableDataGetter rhs,
            PexObjectVariableData.TranslationMask? copyMask = null)
        {
            ((PexObjectVariableDataSetterTranslationCommon)((IPexObjectVariableDataGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IPexObjectVariableData lhs,
            IPexObjectVariableDataGetter rhs,
            out PexObjectVariableData.ErrorMask errorMask,
            PexObjectVariableData.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((PexObjectVariableDataSetterTranslationCommon)((IPexObjectVariableDataGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = PexObjectVariableData.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IPexObjectVariableData lhs,
            IPexObjectVariableDataGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((PexObjectVariableDataSetterTranslationCommon)((IPexObjectVariableDataGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static PexObjectVariableData DeepCopy(
            this IPexObjectVariableDataGetter item,
            PexObjectVariableData.TranslationMask? copyMask = null)
        {
            return ((PexObjectVariableDataSetterTranslationCommon)((IPexObjectVariableDataGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static PexObjectVariableData DeepCopy(
            this IPexObjectVariableDataGetter item,
            out PexObjectVariableData.ErrorMask errorMask,
            PexObjectVariableData.TranslationMask? copyMask = null)
        {
            return ((PexObjectVariableDataSetterTranslationCommon)((IPexObjectVariableDataGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static PexObjectVariableData DeepCopy(
            this IPexObjectVariableDataGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((PexObjectVariableDataSetterTranslationCommon)((IPexObjectVariableDataGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

    }
    #endregion

}

namespace Mutagen.Bethesda.Pex.Internals
{
    #region Field Index
    public enum PexObjectVariableData_FieldIndex
    {
        VariableType = 0,
        StringValue = 1,
        IntValue = 2,
        FloatValue = 3,
        BoolValue = 4,
    }
    #endregion

    #region Registration
    public partial class PexObjectVariableData_Registration : ILoquiRegistration
    {
        public static readonly PexObjectVariableData_Registration Instance = new PexObjectVariableData_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Pex.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Pex.ProtocolKey,
            msgID: 10,
            version: 0);

        public const string GUID = "5abe0b17-91a4-4c71-ae9b-f733317a4a31";

        public const ushort AdditionalFieldCount = 5;

        public const ushort FieldCount = 5;

        public static readonly Type MaskType = typeof(PexObjectVariableData.Mask<>);

        public static readonly Type ErrorMaskType = typeof(PexObjectVariableData.ErrorMask);

        public static readonly Type ClassType = typeof(PexObjectVariableData);

        public static readonly Type GetterType = typeof(IPexObjectVariableDataGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IPexObjectVariableData);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Pex.PexObjectVariableData";

        public const string Name = "PexObjectVariableData";

        public const string Namespace = "Mutagen.Bethesda.Pex";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

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
    public partial class PexObjectVariableDataSetterCommon
    {
        public static readonly PexObjectVariableDataSetterCommon Instance = new PexObjectVariableDataSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IPexObjectVariableData item)
        {
            ClearPartial();
            item.VariableType = default;
            item.StringValue = default;
            item.IntValue = default;
            item.FloatValue = default;
            item.BoolValue = default;
        }
        
    }
    public partial class PexObjectVariableDataCommon
    {
        public static readonly PexObjectVariableDataCommon Instance = new PexObjectVariableDataCommon();

        public PexObjectVariableData.Mask<bool> GetEqualsMask(
            IPexObjectVariableDataGetter item,
            IPexObjectVariableDataGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new PexObjectVariableData.Mask<bool>(false);
            ((PexObjectVariableDataCommon)((IPexObjectVariableDataGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IPexObjectVariableDataGetter item,
            IPexObjectVariableDataGetter rhs,
            PexObjectVariableData.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.VariableType = item.VariableType == rhs.VariableType;
            ret.StringValue = string.Equals(item.StringValue, rhs.StringValue);
            ret.IntValue = item.IntValue == rhs.IntValue;
            ret.FloatValue = item.FloatValue.EqualsWithin(rhs.FloatValue);
            ret.BoolValue = item.BoolValue == rhs.BoolValue;
        }
        
        public string ToString(
            IPexObjectVariableDataGetter item,
            string? name = null,
            PexObjectVariableData.Mask<bool>? printMask = null)
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
            IPexObjectVariableDataGetter item,
            FileGeneration fg,
            string? name = null,
            PexObjectVariableData.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"PexObjectVariableData =>");
            }
            else
            {
                fg.AppendLine($"{name} (PexObjectVariableData) =>");
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
            IPexObjectVariableDataGetter item,
            FileGeneration fg,
            PexObjectVariableData.Mask<bool>? printMask = null)
        {
            if (printMask?.VariableType ?? true)
            {
                fg.AppendItem(item.VariableType, "VariableType");
            }
            if ((printMask?.StringValue ?? true)
                && item.StringValue is {} StringValueItem)
            {
                fg.AppendItem(StringValueItem, "StringValue");
            }
            if ((printMask?.IntValue ?? true)
                && item.IntValue is {} IntValueItem)
            {
                fg.AppendItem(IntValueItem, "IntValue");
            }
            if ((printMask?.FloatValue ?? true)
                && item.FloatValue is {} FloatValueItem)
            {
                fg.AppendItem(FloatValueItem, "FloatValue");
            }
            if ((printMask?.BoolValue ?? true)
                && item.BoolValue is {} BoolValueItem)
            {
                fg.AppendItem(BoolValueItem, "BoolValue");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IPexObjectVariableDataGetter? lhs,
            IPexObjectVariableDataGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if ((crystal?.GetShouldTranslate((int)PexObjectVariableData_FieldIndex.VariableType) ?? true))
            {
                if (lhs.VariableType != rhs.VariableType) return false;
            }
            if ((crystal?.GetShouldTranslate((int)PexObjectVariableData_FieldIndex.StringValue) ?? true))
            {
                if (!string.Equals(lhs.StringValue, rhs.StringValue)) return false;
            }
            if ((crystal?.GetShouldTranslate((int)PexObjectVariableData_FieldIndex.IntValue) ?? true))
            {
                if (lhs.IntValue != rhs.IntValue) return false;
            }
            if ((crystal?.GetShouldTranslate((int)PexObjectVariableData_FieldIndex.FloatValue) ?? true))
            {
                if (!lhs.FloatValue.EqualsWithin(rhs.FloatValue)) return false;
            }
            if ((crystal?.GetShouldTranslate((int)PexObjectVariableData_FieldIndex.BoolValue) ?? true))
            {
                if (lhs.BoolValue != rhs.BoolValue) return false;
            }
            return true;
        }
        
        public virtual int GetHashCode(IPexObjectVariableDataGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.VariableType);
            if (item.StringValue is {} StringValueitem)
            {
                hash.Add(StringValueitem);
            }
            if (item.IntValue is {} IntValueitem)
            {
                hash.Add(IntValueitem);
            }
            if (item.FloatValue is {} FloatValueitem)
            {
                hash.Add(FloatValueitem);
            }
            if (item.BoolValue is {} BoolValueitem)
            {
                hash.Add(BoolValueitem);
            }
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return PexObjectVariableData.GetNew();
        }
        
    }
    public partial class PexObjectVariableDataSetterTranslationCommon
    {
        public static readonly PexObjectVariableDataSetterTranslationCommon Instance = new PexObjectVariableDataSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IPexObjectVariableData item,
            IPexObjectVariableDataGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)PexObjectVariableData_FieldIndex.VariableType) ?? true))
            {
                item.VariableType = rhs.VariableType;
            }
            if ((copyMask?.GetShouldTranslate((int)PexObjectVariableData_FieldIndex.StringValue) ?? true))
            {
                item.StringValue = rhs.StringValue;
            }
            if ((copyMask?.GetShouldTranslate((int)PexObjectVariableData_FieldIndex.IntValue) ?? true))
            {
                item.IntValue = rhs.IntValue;
            }
            if ((copyMask?.GetShouldTranslate((int)PexObjectVariableData_FieldIndex.FloatValue) ?? true))
            {
                item.FloatValue = rhs.FloatValue;
            }
            if ((copyMask?.GetShouldTranslate((int)PexObjectVariableData_FieldIndex.BoolValue) ?? true))
            {
                item.BoolValue = rhs.BoolValue;
            }
        }
        
        #endregion
        
        public PexObjectVariableData DeepCopy(
            IPexObjectVariableDataGetter item,
            PexObjectVariableData.TranslationMask? copyMask = null)
        {
            PexObjectVariableData ret = (PexObjectVariableData)((PexObjectVariableDataCommon)((IPexObjectVariableDataGetter)item).CommonInstance()!).GetNew();
            ((PexObjectVariableDataSetterTranslationCommon)((IPexObjectVariableDataGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public PexObjectVariableData DeepCopy(
            IPexObjectVariableDataGetter item,
            out PexObjectVariableData.ErrorMask errorMask,
            PexObjectVariableData.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            PexObjectVariableData ret = (PexObjectVariableData)((PexObjectVariableDataCommon)((IPexObjectVariableDataGetter)item).CommonInstance()!).GetNew();
            ((PexObjectVariableDataSetterTranslationCommon)((IPexObjectVariableDataGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = PexObjectVariableData.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public PexObjectVariableData DeepCopy(
            IPexObjectVariableDataGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            PexObjectVariableData ret = (PexObjectVariableData)((PexObjectVariableDataCommon)((IPexObjectVariableDataGetter)item).CommonInstance()!).GetNew();
            ((PexObjectVariableDataSetterTranslationCommon)((IPexObjectVariableDataGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Pex
{
    public partial class PexObjectVariableData
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => PexObjectVariableData_Registration.Instance;
        public static PexObjectVariableData_Registration Registration => PexObjectVariableData_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => PexObjectVariableDataCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return PexObjectVariableDataSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => PexObjectVariableDataSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IPexObjectVariableDataGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IPexObjectVariableDataGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IPexObjectVariableDataGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

