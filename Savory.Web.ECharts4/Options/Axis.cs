using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    /// <summary>
    /// 坐标轴
    /// </summary>
    public abstract class Axis
    {
        /// <summary>
        /// 坐标轴类型
        /// </summary>
        [JsonProperty("type")]
        public AxisType AXisType { get; set; }

        /// <summary>
        /// 通常是 List&lt;T&gt;，如果T是string，则T里面可以包含 '\n'，用于在页面上换行
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; set; }
    }
}
