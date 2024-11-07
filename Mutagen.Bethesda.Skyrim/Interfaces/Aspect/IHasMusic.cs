using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.SourceGenerators;

namespace Mutagen.Bethesda.Skyrim;

/// <summary>
/// Common interface for records with a MusicType
/// </summary>
[CustomAspectInterface(typeof(ICell), typeof(IWorldspace))]
public interface IHasMusic : ISkyrimMajorRecordInternal, IHasMusicGetter
{
    IFormLinkNullable<IMusicTypeGetter> Music { get; }
}

/// <summary>
/// Common interface for records with a MusicType
/// </summary>
[CustomAspectInterface(typeof(ICell), typeof(ICellGetter), typeof(IWorldspace), typeof(IWorldspaceGetter))]
public interface IHasMusicGetter : ISkyrimMajorRecordGetter
{
    IFormLinkNullableGetter<IMusicTypeGetter> Music { get; }
}