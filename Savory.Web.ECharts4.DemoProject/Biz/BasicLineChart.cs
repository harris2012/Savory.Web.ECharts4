using Savory.Web.ECharts4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject.Biz
{
    [Example("Basic Line Chart")]
    public class BasicLineChart : ProcessorBase
    {
        public override EChartsOption GetOption()
        {
            var option = new EChartsOption();

            option.XAxisCollection = new XAxis
            {
                AXisType = AxisType.Category,
                Data = new List<string> { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" }
            };

            option.YAxisCollection = new YAxis { AXisType = AxisType.Value };

            option.SerieList = new List<Serie>();
            option.SerieList.Add(new Serie());
            option.SerieList[0].Data = new List<int> { 820, 932, 901, 934, 1290, 1330, 1320 };
            option.SerieList[0].SerieType = SerieTypeEnum.Line;

            return option;
        }
    }
}