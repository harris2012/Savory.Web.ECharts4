using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class YAxis : Axis
    {
        [JsonProperty("inverse")]
        public bool? Inverse { get; set; }

        [JsonProperty("max")]
        public int? Max { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameLocation")]
        public string NameLocation { get; set; }
    }
}
