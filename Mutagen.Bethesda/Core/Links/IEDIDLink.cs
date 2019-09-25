﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutagen.Bethesda
{
    public interface IEDIDLinkGetter<out T> : ILinkGetter<T>
       where T : IMajorRecordCommonGetter
    {
        RecordType EDID { get; }
    }

    public interface IEDIDLink<T> : IEDIDLinkGetter<T>, ILink<T>
       where T : IMajorRecordCommonGetter
    {
        void Set(RecordType item);
    }

    public interface IEDIDSetLinkGetter<out T> : IEDIDLinkGetter<T>, ISetLinkGetter<T>
       where T : IMajorRecordCommonGetter
    {
    }

    public interface IEDIDSetLink<T> : IEDIDLink<T>, ISetLink<T>, IEDIDSetLinkGetter<T>
       where T : IMajorRecordCommonGetter
    {
    }
}
