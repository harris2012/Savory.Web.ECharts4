using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class DataZoom
    {
        [JsonProperty("show")]
        public bool? Show { get; set; }

        [JsonProperty("realtime")]
        public bool? RealTime { get; set; }

        [JsonProperty("start")]
        public int? Start { get; set; }

        [JsonProperty("end")]
        public int? End { get; set; }


        [JsonProperty("yAxisIndex")]
        public object YAxisIndex { get; set; }

        [JsonProperty("xAxisIndex")]
        public object XAxisIndex { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
