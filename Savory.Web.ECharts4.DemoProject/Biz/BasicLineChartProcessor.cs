using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject.Biz
{
    public class BasicLineChartProcessor : ProcessorBase
    {
        public override object GetOption()
        {
            var option = new EChartsOption();

            option.XAxis = new Options.XAxis { AXisType = Options.AxisType.Category };

            option.YAxis = new Options.YAxis { AXisType = Options.AxisType.Value };

            return option;


            var categories = new List<string> { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            List<int> items = new List<int> { 820, 932, 901, 934, 1290, 1330, 1320 };

            return new { xAxisData = categories, seriesData = items };
        }
    }
}