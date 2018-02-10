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
            int count = 100;

            EChartsOption option = new EChartsOption();

            option.CreateTitle("柱状图动画延迟");

            option.Legend = new Legend { Data = new List<string> { "bar", "bar2" } };

            option.Tooltip = new Tooltip { };

            option.XAxisCollection = new XAxis { Data = GetList(count) };

            option.YAxisCollection = new YAxis { };

            option.SerieList = new List<Serie>();

            option.SerieList.Add(new Serie
            {
                Name = "bar",
                SerieType = SerieTypeEnum.Bar,
                Data = GetList(i =>
                {
                    return (Math.Sin(i / 5) * (i / 5 - 10) + i / 6) * 5;
                }, count)
            });

            option.SerieList.Add(new Serie
            {
                Name = "bar2",
                SerieType = SerieTypeEnum.Bar,
                Data = GetList(i =>
                {
                    return (Math.Cos(i / 5) * (i / 5 - 10) + i / 6) * 5;
                }, count)
            });

            return option;
        }

        /*
        var json="{\"xx\":\"function(){alert(123)}\"}";

        var item=JSON.parse(json)

        for(var k in item)
        {
          eval('(function(){ var f='+item[k]+';item[k]=f;  })()')
        }

        item.xx();
                     */

        private static List<string> GetList(int count)
        {
            List<string> returnValue = new List<string>();

            for (int i = 0; i < count; i++)
            {
                returnValue.Add("类库" + i);
            }

            return returnValue;
        }

        private static List<double> GetList(Func<double, double> func, int count)
        {
            List<double> returnValue = new List<double>();

            for (int i = 0; i < count; i++)
            {
                returnValue.Add(func(i));
            }

            return returnValue;
        }
    }
}