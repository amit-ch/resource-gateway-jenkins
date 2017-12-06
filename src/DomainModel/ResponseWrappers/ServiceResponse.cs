using System.Collections.Generic;

namespace GatewayAssets.DomainModel.ResponseWrappers
{
    public class ServiceResponse
    {
        public virtual Meta Meta { get; set; }
        public virtual List<Asset.Asset> AssetItems { get; set; }
    }
}