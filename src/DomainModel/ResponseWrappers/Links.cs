using System;
using System.Collections.Generic;
using System.Text;

namespace GatewayAssets.DomainModel.ResponseWrappers
{
    public class Links
    {
        public virtual Link Self { get; set; }
        public virtual Link First { get; set; }
        public virtual Link Prev { get; set; }
        public virtual Link Next { get; set; }
        public virtual Link Last { get; set; }
    }
}
