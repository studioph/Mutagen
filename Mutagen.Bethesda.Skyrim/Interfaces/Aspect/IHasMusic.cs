using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.Skyrim;

/// <summary>
/// Common interface for records with a MusicType
/// </summary>
public interface IHasMusic : ISkyrimMajorRecordInternal, IHasMusicGetter
{
    IFormLinkNullable<IMusicTypeGetter> Music { get; }
}

/// <summary>
/// Common interface for records with a MusicType
/// </summary>
public interface IHasMusicGetter : ISkyrimMajorRecordGetter
{
    IFormLinkNullableGetter<IMusicTypeGetter> Music { get; }
}