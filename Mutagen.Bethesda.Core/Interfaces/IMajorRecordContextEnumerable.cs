using System;
using System.Collections.Generic;
using Mutagen.Bethesda.Records;

namespace Mutagen.Bethesda
{
    public interface IMajorRecordContextEnumerable<TMod, TModGetter>
        where TModGetter : IModGetter
        where TMod : TModGetter, IMod
    {
        /// <summary>  
        /// Enumerates all contained Major Record Getters of the specified generic type  
        /// </summary>
        /// <param name="linkCache">LinkCache to use when creating parent objects</param> 
        /// <param name="throwIfUnknown">Whether to throw an exception if type is unknown</param> 
        /// <exception cref="ArgumentException">If a non applicable type is provided, and throw parameter is on</exception>
        /// <returns>Enumerable of all applicable major records</returns>  
        IEnumerable<IModContext<TMod, TModGetter, TSetter, TGetter>> EnumerateMajorRecordContexts<TSetter, TGetter>(ILinkCache linkCache, bool throwIfUnknown = true)
            where TSetter : class, IMajorRecordCommon, TGetter
            where TGetter : class, IMajorRecordCommonGetter;

        /// <summary>  
        /// Enumerates all contained Major Record Getters of the specified type  
        /// </summary>  
        /// <param name="linkCache">LinkCache to use when creating parent objects</param> 
        /// <param name="t">Type to query and iterate</param> 
        /// <param name="throwIfUnknown">Whether to throw an exception if type is unknown</param> 
        /// <exception cref="ArgumentException">If a non applicable type is provided, and throw parameter is on</exception>
        /// <returns>Enumerable of all applicable major records</returns>  
        IEnumerable<IModContext<TMod, TModGetter, IMajorRecordCommon, IMajorRecordCommonGetter>> EnumerateMajorRecordContexts(ILinkCache linkCache, Type t, bool throwIfUnknown = true);
    }
}
