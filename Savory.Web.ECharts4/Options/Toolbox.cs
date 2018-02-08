using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class Toolbox
    {
        [JsonProperty("show")]
        public bool Show { get; set; }

        [JsonProperty("feature")]
        public Feature Feature { get; set; }
    }
}
