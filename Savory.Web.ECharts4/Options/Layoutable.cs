using Newtonsoft.Json;
using Savory.Web.ECharts4.Convertor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public abstract class Layoutable : View
    {
        /// <summary>
        /// 离容器左侧的距离 string, number
        /// 可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'left', 'center', 'right'
        /// </summary>
        [JsonProperty("left")]
        [JsonConverter(typeof(LeftConvertor))]
        public Left Left { get; set; }

        /// <summary>
        ///  组件离容器右侧的距离 string, number
        ///  可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比
        /// </summary>
        [JsonProperty("right")]
        public string Right { get; set; }

        /// <summary>
        /// 组件离容器上侧的距离 string, number
        /// 可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'top', 'middle', 'bottom'
        /// </summary>
        [JsonProperty("top")]
        public string Top { get; set; }

        /// <summary>
        /// 组件离容器下侧的距离 string, number
        /// 可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比
        /// </summary>
        [JsonProperty("bottom")]
        public string Bottom { get; set; }
    }
}
