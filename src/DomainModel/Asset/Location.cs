using System.Collections.Generic;

namespace GatewayAssets.DomainModel.Asset
{
    public class Location
    {
        public string Path { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public string FileSize { get; set; }
        public string Format { get; set; }
        public List<Rendition> Renditions { get; set; }
    }
}