using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public abstract class View
    {
        /// <summary>
        /// 是否在界面上显示
        /// </summary>
        [JsonProperty("show")]
        public bool? Show { get; set; }
    }
}
