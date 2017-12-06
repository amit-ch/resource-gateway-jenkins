using System.ComponentModel;

namespace GatewayAssets.DomainModel.Asset
{
    public enum SourceSystem
    {
        [Description("Cortex")] Cortex,
        [Description("Sony")] Sony
    }

    public enum AssetType
    {
        [Description("Audio")] Audio,
        [Description("Document")] Document,
        [Description("Image")] Image,
        [Description("Video")] Video,
        [Description("Artwork")] Artwork
    }

    public enum ContentType
    {
        [Description("TitleGroup")] TitleGroup,
        [Description("Title")] Title,
        [Description("TitleVersion")] TitleVersion,
        [Description("SeriesConfig")] SeriesConfig,
        [Description("SeriesConfigVersion")] SeriesConfigVersion,
        [Description("Episode")] Episode,
        [Description("ContentVersion")] ContentVersion
    }

    public enum AssetStatus
    {
        [Description("Published")] Published,
        [Description("Revoked")] Revoked
    }

    public enum DocumentType
    {
        [Description("Music Cue Sheet")] MusicCueSheet,
        [Description("Script")] Script,
        [Description("Caption List")] CaptionList,
        [Description("Programme As Complete")] PasC
    }

    public enum RenditionType
    {
        [Description("Thumbnail")] Thumbnail,
        [Description("LowRes")] LowRes
    }

}