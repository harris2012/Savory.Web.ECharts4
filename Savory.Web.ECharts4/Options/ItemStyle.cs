using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class ItemStyle
    {
        [JsonProperty("label")]
        public Label Label { get; set; }

        [JsonProperty("labelLine")]
        public LabelLine LabelLine { get; set; }
    }

    public class Label
    {
        [JsonProperty("show")]
        public bool? Show { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("textStyle")]
        public TextStyle TextStyle { get; set; }
    }

    public class LabelLine
    {
        [JsonProperty("show")]
        public bool? Show { get; set; }
    }

    public class TextStyle
    {
        [JsonProperty("fontSize")]
        public int FontSize { get; set; }

        [JsonProperty("fontWeight")]
        public string FontWeight { get; set; }
    }
}
