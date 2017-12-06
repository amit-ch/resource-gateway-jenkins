namespace GatewayAssets.DomainModel.Asset
{
    public class DocumentAsset : Asset
    {
        public override string Type => AssetType.Document.ToString();
        public string DocumentType { get; set; }
    }
}