using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject.BizOption
{
    public class BasicLineChartProcessor : OptionProcessorBase
    {
        public override object Process()
        {
            var option = new EChartsOption();

            option.XAxis = new Options.XAxis { AXisType = Options.AxisType.Category };

            option.YAxis = new Options.YAxis { AXisType = Options.AxisType.Value };

            return option;
        }
    }
}