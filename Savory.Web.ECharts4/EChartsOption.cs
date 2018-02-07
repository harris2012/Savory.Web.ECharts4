using Savory.Web.ECharts4.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class EChartsOption
    {
        [AsOne]
        [EChartsProperty("title")]
        public List<Title> Title { get; set; }
    }
}
