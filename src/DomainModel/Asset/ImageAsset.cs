namespace GatewayAssets.DomainModel.Asset
{
    public class ImageAsset : Asset
    {
        public override string Type => AssetType.Image.ToString();
        public string ColorProfile { get; set; }
        public string MediaMetadata { get; set; }
    }
}