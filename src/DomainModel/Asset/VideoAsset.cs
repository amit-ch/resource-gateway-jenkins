namespace GatewayAssets.DomainModel.Asset
{
    public class VideoAsset : Asset
    {
        public override string Type => AssetType.Video.ToString();
        public string ActivePictureFormat { get; set; }
        public string ScreenAspectRatio { get; set; }
        public string ImageAspectRatio { get; set; }
        public string FrameRate { get; set; }
        public string TextedLanguage { get; set; }
        public bool MusicAndEffects { get; set; }
        public bool CloseCaptionAvailable { get; set; }
        public string Standard { get; set; }
        public string LineStandard { get; set; }
        public string Container { get; set; }
        public string Codec { get; set; }
        public string BarCode { get; set; }
        public int RunTimeInSeconds { get; set; }
    }
}