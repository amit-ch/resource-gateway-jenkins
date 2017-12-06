using System.Collections.Generic;

namespace GatewayAssets.DomainModel.Asset
{
    public class AudioAsset : Asset
    {
        public override string Type => AssetType.Audio.ToString();
        public string Codec { get; set; }
        public string Language { get; set; }
        public string FileLayout { get; set; }
        public string Container { get; set; }
        public List<AudioContent> AudioContent { get; set; }
        public List<TrackConfiguration> TrackConfiguration { get; set; }
    }
}