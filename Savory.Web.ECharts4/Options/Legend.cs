using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4.Options
{
    public class Legend
    {
        [JsonProperty("orient")]
        public string Orient { get; set; }

        [JsonProperty("x")]
        public string X { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
