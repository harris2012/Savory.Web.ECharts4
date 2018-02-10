using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject.Biz
{
    [Example("Rainfall")]
    public class Line_Rainfall : ProcessorBase
    {
        public override EChartsOption GetOption()
        {
            EChartsOption option = new EChartsOption();

            option.CreateTitle("雨量流量关系图").SetSubText("数据来自西安兰特水电测控技术有限公司").SetLeft(LeftEnum.Center);

            option.GridCollection = new Grid { Bottom = 80 };

            option.Toolbox = new Toolbox { Feature = new Feature { Restore = { }, SaveAsImage = { }, DataZoom = new DataZoom { YAxisIndex = "none" } } };

            option.Tooltip = new Tooltip { Trigger = "axis", AxisPointer = new AxisPointer { Type = "cross", Animation = false, Label = new Label { BackgroundColor = "#505765" } } };

            option.Legend = new Legend { Left = LeftEnum.Left, Data = new List<string> { "流量", "降雨量" } };

            option.DataZoom = new List<DataZoom>();
            option.DataZoom.Add(new DataZoom { Show = true, RealTime = true, Start = 65, End = 85 });
            option.DataZoom.Add(new DataZoom { Type = "inside", RealTime = true, Start = 65, End = 85 });

            DateTime start = new DateTime(2009, 6, 12, 2, 0, 0);
            DateTime end = new DateTime(2009, 6, 14, 0, 0, 0);
            //DateTime end = new DateTime(2009, 6, 13, 0, 0, 0);

            option.XAxisCollection = new XAxis
            {
                AXisType = AxisTypeEnum.Category,
                BoundaryGap = false,
                AxisLine = new AxisLine { OnZero = false }
            };
            option.XAxisCollection[0].Data = GetTimes(start, end);

            option.YAxisCollection = new YAxisCollection();
            option.YAxisCollection.Add(new YAxis { AXisType = AxisType.Value, Name = "流量(m^3/s)", Max = 500 });
            option.YAxisCollection.Add(new YAxis { AXisType = AxisType.Value, Name = "降雨量(mm)", NameLocation = "start", Inverse = true, Max = 5 });

            option.SerieList = new List<Serie>();
            option.SerieList.Add(new Serie
            {
                Name = "流量",
                SerieType = SerieTypeEnum.Line,
                Animation = false,
                AreaStyle = new AreaStyle
                {
                    Normal = new object { }
                },
                LineStyle = new LineStyle { Width = 1 },
                Data = GetValues(start, end, 100, 10000)
            });
            option.SerieList.Add(new Serie
            {
                Name = "降水量",
                SerieType = SerieTypeEnum.Line,
                Animation = false,
                YAxisIndex = 1,
                AreaStyle = new AreaStyle
                {
                    Normal = new object { }
                },
                LineStyle = new LineStyle { Width = 1 },
                Data = GetValues(start, end, 0, 100)
            });

            return option;
        }

        /// <summary>
        /// 获取时间序列
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private static List<string> GetTimes(DateTime start, DateTime end)
        {
            List<string> returnValue = new List<string>();

            while (start < end)
            {
                returnValue.Add(start.AddHours(1).ToString("yyyy/MM/dd HH:mm"));

                start = start.AddHours(1);
            }

            return returnValue;
        }

        /// <summary>
        /// 获取流量序列
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private static List<double> GetValues(DateTime start, DateTime end, int min, int max)
        {
            List<double> returnValue = new List<double>();

            Random random = new Random();

            while (start < end)
            {
                var value = ((double)random.Next(min, max)) / 100;

                returnValue.Add(value);

                start = start.AddHours(1);
            }

            return returnValue;
        }
    }
}