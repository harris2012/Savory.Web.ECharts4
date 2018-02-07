using Newtonsoft.Json;
using Savory.Web.ECharts4.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class EChartsOption
    {
        [JsonProperty("title")]
        public List<Title> TitleList { get; set; }

        [JsonProperty("legend")]
        public Legend Legend { get; set; }

        [JsonProperty("toolbox")]
        public Toolbox Toolbox { get; set; }

        [JsonProperty("calculable")]
        public bool Calculable { get; set; }

        [JsonProperty("series")]
        public List<Serie> SerieList { get; set; }

        [JsonProperty("tooltip")]
        public Tooltip Tooltip { get; set; }
    }
}
