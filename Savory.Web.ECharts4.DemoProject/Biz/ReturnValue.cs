using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject.Biz
{
    public class ReturnValue
    {
        [JsonProperty("legendData")]
        public List<string> LegendData { get; set; }

        [JsonProperty("serieData")]
        public List<Serie> SerieData { get; set; }
    }

    public class Serie
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }
}