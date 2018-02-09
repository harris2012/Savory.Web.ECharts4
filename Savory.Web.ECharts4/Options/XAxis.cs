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
        [JsonProperty("axisLine")]
        public AxisLine AxisLine { get; set; }

        [JsonProperty("boundaryGap")]
        public bool? BoundaryGap { get; set; }
    }

    public class AxisLine
    {
        [JsonProperty("onZero")]
        public bool? OnZero { get; set; }
    }
}
