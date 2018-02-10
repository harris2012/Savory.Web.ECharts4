using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject.Biz
{
    [Example("Stacked Area Chart")]
    public class Line_StackedAreaChart : ProcessorBase
    {
        public object Normal { get; private set; }

        public override EChartsOption GetOption()
        {
            EChartsOption option = new EChartsOption();

            option.CreateTitle("堆叠区域图");

            option.Tooltip = new Tooltip { Trigger = "axis", AxisPointer = new AxisPointer { Type = "cross", Label = new Label { BackgroundColor = "#6a7985" } } };

            option.Legend = new Legend { Data = new List<string> { "邮件营销", "联盟广告", "视频广告", "直接访问", "搜索引擎" } };

            option.Toolbox = new Toolbox { Feature = new Feature { SaveAsImage = new SaveAsImage() } };

            option.GridCollection = new Grid { Left = 0.03, Right = 0.04, Bottom = 0.03, ContainLabel = true };

            option.XAxisCollection = new XAxis
            {
                AXisType = AxisType.Category,
                BoundaryGap = false,
                Data = new List<string> { "周一", "周二", "周三", "周四", "周五", "周六", "周日" }
            };

            option.YAxisCollection = new YAxis { AXisType = AxisType.Value };

            option.SerieList = new List<Serie>();
            option.SerieList.Add(new Serie
            {
                Name = "邮件营销",
                SerieType = SerieTypeEnum.Line,
                Stack = "总量",
                AreaStyle = new AreaStyle { Normal = new object() },
                Data = new List<int> { 120, 132, 101, 134, 90, 230, 210 }
            });

            option.SerieList.Add(new Serie
            {
                Name = "联盟广告",
                SerieType = SerieTypeEnum.Line,
                Stack = "总量",
                AreaStyle = new AreaStyle { Normal = new object() },
                Data = new List<int> { 220, 182, 191, 234, 290, 330, 310 }
            });

            option.SerieList.Add(new Serie
            {
                Name = "视频广告",
                SerieType = SerieTypeEnum.Line,
                Stack = "总量",
                AreaStyle = new AreaStyle { Normal = new object() },
                Data = new List<int> { 150, 232, 201, 154, 190, 330, 410 }
            });

            option.SerieList.Add(new Serie
            {
                Name = "直接访问",
                SerieType = SerieTypeEnum.Line,
                Stack = "总量",
                AreaStyle = new AreaStyle { Normal = new object() },
                Data = new List<int> { 320, 332, 301, 334, 390, 330, 320 }
            });

            option.SerieList.Add(new Serie
            {
                Name = "搜索引擎",
                SerieType = SerieTypeEnum.Line,
                Stack = "总量",
                Label = new LabelMap { Normal = new Label { Show = true, Position = "top" } },
                AreaStyle = new AreaStyle { Normal = new object() },
                Data = new List<int> { 820, 932, 901, 934, 1290, 1330, 1320 }
            });

            return option;
        }
    }
}