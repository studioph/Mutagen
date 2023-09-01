/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
using System;
using System.Collections.Generic;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Loqui;

namespace Mutagen.Bethesda.Starfield;

internal class StarfieldLinkInterfaceMapping : IInterfaceMapping
{
    public IReadOnlyDictionary<Type, InterfaceMappingResult> InterfaceToObjectTypes { get; }

    public GameCategory GameCategory => GameCategory.Starfield;

    public StarfieldLinkInterfaceMapping()
    {
        var dict = new Dictionary<Type, InterfaceMappingResult>();
        dict[typeof(IKeywordLinkedReference)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            Keyword_Registration.Instance,
        });
        dict[typeof(IKeywordLinkedReferenceGetter)] = dict[typeof(IKeywordLinkedReference)] with { Setter = false };
        InterfaceToObjectTypes = dict;
    }
}

