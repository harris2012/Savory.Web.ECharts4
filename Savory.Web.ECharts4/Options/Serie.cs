using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4.Options
{
    public class Serie
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public SerieType? SerieType { get; set; }

        [JsonProperty("data")]
        public List<SerieData> Data { get; set; }

        [JsonProperty("radius")]
        public List<string> Radius { get; set; }

        //[JsonProperty("itemStyle")]
        //public ItemStyle ItemStyle { get; set; }
    }
}
