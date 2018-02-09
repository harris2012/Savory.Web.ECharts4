using Newtonsoft.Json;
using Savory.Web.ECharts4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public partial class EChartsOption
    {
        /// <summary>
        /// 标题组件
        /// </summary>
        [JsonProperty("title")]
        public TitleCollection TitleCollection { get; set; }

        [JsonProperty("legend")]
        public Legend Legend { get; set; }


        [JsonProperty("toolbox")]
        public Toolbox Toolbox { get; set; }


        [JsonProperty("calculable")]
        public bool? Calculable { get; set; }

        [JsonProperty("tooltip")]
        public Tooltip Tooltip { get; set; }

        /// <summary>
        /// 横坐标
        /// </summary>
        [JsonProperty("xAxis")]
        public XAxisCollection XAxisCollection { get; set; }

        /// <summary>
        /// 纵坐标
        /// </summary>
        [JsonProperty("yAxis")]
        public YAxisCollection YAxisCollection { get; set; }

        /// <summary>
        /// 系列
        /// </summary>
        [JsonProperty("series")]
        public List<Serie> SerieList { get; set; }

        /// <summary>
        /// 网格
        /// </summary>
        [JsonProperty("grid")]
        public GridCollection GridCollection { get; set; }

        [JsonProperty("dataZoom")]
        public List<DataZoom> DataZoom { get; set; }
    }
}
