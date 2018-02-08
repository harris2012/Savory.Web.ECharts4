using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class Feature
    {
        [JsonProperty("restore")]
        public Restore Restore { get; set; }

        [JsonProperty("saveAsImage")]
        public SaveAsImage SaveAsImage { get; set; }
    }

    public class Restore
    {
        [JsonProperty("show")]
        public bool Show { get; set; }
    }

    public class SaveAsImage
    {
        [JsonProperty("show")]
        public bool Show { get; set; }
    }
}
