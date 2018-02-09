using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public partial class Title : Layoutable
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("subtext")]
        public string SubText { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("sublink")]
        public string SubLink { get; set; }
    }
}
