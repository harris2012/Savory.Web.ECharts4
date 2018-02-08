using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class Tooltip
    {
        [JsonProperty("trigger")]
        public string Trigger { get; set; }

        [JsonProperty("formatter")]
        public string Formatter { get; set; }

        [JsonProperty("axisPointer")]
        public AxisPointer AxisPointer { get; set; }
    }
}
