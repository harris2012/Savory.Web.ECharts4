using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject.Biz
{
    [Example("Doughnut Chart")]
    public class Pie_DoughnutChart : ProcessorBase
    {
        public override EChartsOption GetOption()
        {
            EChartsOption option = new EChartsOption();

            option.Tooltip = new Tooltip { Trigger = "item", Formatter = "{a} <br/>{b}: {c} ({d}%)" };

            option.Legend = new Legend { Orient = "vertical", Left = LeftEnum.Left, Data = new List<string> { "直接访问", "邮件营销", "联盟广告", "视频广告", "搜索引擎" } };

            option.SerieList = new List<Serie>();

            option.SerieList.Add(new Serie
            {
                Name = "访问来源",
                SerieType = SerieTypeEnum.Pie,
                Radius = new List<string> { "50%", "70%" },
                Label = new LabelMap
                {
                    Normal = new Label
                    {
                        Show = false,
                        Position = "center"
                    },
                    Emphasis = new Label
                    {
                        Show = true,
                        TextStyle = new TextStyle { FontSize = 30, FontWeight = "bold" }
                    }
                },
                AvoidLabelOverlap = false,
                LabelLine = new LabelLineMap { Normal = new LabelLine { Show = false } },
                Data = new List<SerieData>
                {
                    new SerieData { Name="直接访问",Value=335 },
                    new SerieData { Name="邮件营销",Value= 310},
                    new SerieData { Name="联盟广告",Value=234 },
                    new SerieData { Name="视频广告",Value= 135},
                    new SerieData { Name="搜索引擎",Value= 1548}

                }
            });

            /*
             app.title = '环形图';

            option = {
                series: [
                    {
                        name:'访问来源',
                        type:'pie',
                        radius: ['50%', '70%'],
                        avoidLabelOverlap: false,
                    }
                ]
            };

                         */

            return option;
        }
    }
}