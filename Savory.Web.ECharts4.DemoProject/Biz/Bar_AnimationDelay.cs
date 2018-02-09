using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject.Biz
{
    [Example("柱状图动画延迟")]
    public class Bar_AnimationDelay : ProcessorBase
    {
        public override EChartsOption GetOption()
        {
            EChartsOption option = new EChartsOption();

            option.CreateTitle("柱状图动画延迟");

            option.Legend = new Legend { Left = LeftEnum.Left, Data = new List<string> { "bar", "bar2" } };

            return option;
        }
    }
}