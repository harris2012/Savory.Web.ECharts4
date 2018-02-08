using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class Serie
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public SerieType SerieType { get; set; }

        [JsonProperty("data")]
        public SerieDataCollection Data { get; set; }

        [JsonProperty("radius")]
        public List<string> Radius { get; set; }

        [JsonProperty("itemStyle")]
        public Dictionary<string, ItemStyle> ItemStyle { get; set; }

        [JsonProperty("areaStyle")]
        public AreaStyle AreaStyle { get; set; }

        [JsonProperty("smooth")]
        public bool? Smooth { get; set; }
    }
}
