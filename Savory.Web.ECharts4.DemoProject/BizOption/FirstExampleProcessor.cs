using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject.BizOption
{
    public class FirstExampleProcessor : OptionProcessorBase
    {
        public override object Process()
        {
            EChartsOption option = new EChartsOption();
            option.TitleList = new List<Options.Title>();
            option.TitleList.Add(new Options.Title { Text = "MainTitle", SubText = "link", Left = LeftEnum.Center });
            option.Legend = new Options.Legend { Orient = "vertical", X = "left" };
            option.Toolbox = new Options.Toolbox
            {
                Show = true,
                Feature = new Options.Feature
                {
                    Restore = new Options.Restore { Show = true },
                    SaveAsImage = new Options.SaveAsImage { Show = true }
                }
            };
            option.Tooltip = new Options.Tooltip { Formatter = "{a} <br/>{b} : {c} ({d}%)", Trigger = "item" };
            option.Calculable = true;

            return option;
        }
    }
}