using System;
using System.Collections.Generic;

namespace GatewayAssets.DomainModel.Asset
{
    public class AssetList
    {
        public List<string> Identifiers;
        public DateTime EndDate { get; set; }
    }
}
