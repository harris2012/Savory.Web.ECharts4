using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class XAxis : Axis
    {
        [JsonProperty("boundaryGap")]
        public bool? BoundaryGap { get; set; }
    }
}
