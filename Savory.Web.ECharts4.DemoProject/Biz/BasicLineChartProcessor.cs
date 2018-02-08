using Savory.Web.ECharts4.Options;
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

            option.XAxis = new Options.XAxis
            {
                AXisType = Options.AxisType.Category,
                Data = new List<string> { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" }
            };

            option.YAxis = new Options.YAxis { AXisType = Options.AxisType.Value };

            option.SerieList = new List<Options.Serie>();
            option.SerieList.Add(new Options.Serie());
            option.SerieList[0].Data = new List<int> { 820, 932, 901, 934, 1290, 1330, 1320 };
            option.SerieList[0].SerieType = SerieTypeEnum.Line;

            return option;
        }
    }
}