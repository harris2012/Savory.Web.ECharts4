using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject.Biz
{
    [Example("Basic Area Chart")]
    public class Line_BasicAreaChart : ProcessorBase
    {
        public override EChartsOption GetOption()
        {
            EChartsOption option = new EChartsOption();

            option.XAxisCollection = new XAxis
            {
                AXisType = AxisType.Category,
                Data = new List<string> { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" },
                BoundaryGap = false
            };

            option.YAxisCollection = new YAxis { AXisType = AxisType.Value };

            option.SerieList = new List<Serie>();
            option.SerieList.Add(new Serie
            {
                SerieType = SerieTypeEnum.Line,
                Data = new List<int> { 820, 932, 901, 934, 1290, 1330, 1320 },
                AreaStyle = new AreaStyle()
            });

            return option;
        }
    }
}