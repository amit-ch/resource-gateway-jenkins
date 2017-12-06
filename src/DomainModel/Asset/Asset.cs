using System.Collections.Generic;
using Newtonsoft.Json;

namespace GatewayAssets.DomainModel.Asset
{

        public abstract class Asset
        {
            public virtual string Identifier { get; set; }

            public virtual string Name { get; set; }

            public virtual Source Source { get; set; }

            public virtual Content Content { get; set; }

            public virtual string Title { get; set; }

            public virtual string Description { get; set; }

            [JsonProperty(Required = Required.Always)]
            public virtual string Type { get; set; }

            public virtual string Status { get; set; }

            public virtual bool Sensitive { get; set; }

            public virtual List<Keyword> Keywords { get; set; }

            public virtual Location Location { get; set; }
        }
    }

