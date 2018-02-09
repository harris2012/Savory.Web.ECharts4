using Savory.Web.ECharts4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject.Biz
{
    [Example("First Example")]
    public class A_FirstExample : ProcessorBase
    {
        public override EChartsOption GetOption()
        {
            EChartsOption option = new EChartsOption();
            option.TitleCollection = new List<Title>();
            option.TitleCollection.Add(new Title { Text = "MainTitle", SubText = "link", Left = LeftEnum.Center });

            option.Toolbox = new Toolbox
            {
                Show = true,
                Feature = new Feature
                {
                    Restore = new Restore { Show = true },
                    SaveAsImage = new SaveAsImage { Show = true }
                }
            };
            option.Tooltip = new Tooltip { Formatter = "{a} <br/>{b} : {c} ({d}%)", Trigger = "item" };
            option.Calculable = true;

            option.Legend = new Legend { Orient = "vertical", Left = LeftEnum.Left };
            option.Legend.Data = new List<string>
            {
                "成功",
                "[优惠平台]优惠券已使用",
                "[度假]优惠券在当前订单没有匹配的阶梯",
                "[度假]该产品不可以使用该优惠券",
                "[优惠平台]使用次数超过策略允许最大值",
                "[度假]订单原始金额(orderAmount)必须是正数",
                "[优惠平台]优惠券不存在",
                "[优惠平台]风控屏蔽！",
                "[优惠平台]产线ID与策略不匹配",
                "[度假]优惠券在当前平台(platformId)不可用",
                "[优惠平台]优惠券所属适用站点不匹配",
                "[度假]优惠券在当前渠道不可用",
                "[优惠平台]该限时优惠券已被其他用户收藏",
                "[优惠平台]券码不合法",
                "[度假]用户信息(UserInfo)必传",
                "[度假]这张订单想要优惠的金额太多了",
                "[度假]优惠券没有被设置",
                "[优惠平台]优惠券已经失效",
                "[优惠平台]活动已经结束了"
            };

            //option.series = [{
            //    name: '访问来源',
            //    type: 'pie',
            //    radius: ['50%', '70%'],
            //    itemStyle: {
            //        normal: { label: { show: false }, labelLine: { show: false } },
            //        emphasis: { label: { show: true, position: 'center', textStyle: { fontSize: '30', fontWeight: 'bold' } } }
            //    },
            //    data: data.serieData
            //}];

            option.SerieList = new List<Serie>();
            option.SerieList.Add(new Serie
            {
                Name = "访问来源",
                SerieType = SerieTypeEnum.Pie,
                Radius = new
                List<string> { "50%", "70%" }
            });
            option.SerieList[0].ItemStyle = new Dictionary<string, ItemStyle>();
            option.SerieList[0].ItemStyle.Add("normal", new ItemStyle
            {
                Label = new Label { Show = false },
                LabelLine = new LabelLine
                {
                    Show = false
                }
            });
            option.SerieList[0].ItemStyle.Add("emphasis", new ItemStyle
            {
                Label = new Label
                {
                    Show = true,
                    Position = "center",
                    TextStyle = new TextStyle
                    {
                        FontSize = 30,
                        FontWeight = "bold"
                    }
                }
            });

            option.SerieList[0].Data = new List<SerieData>
            {
                new SerieData { Name="成功", Value= 10503},
                new SerieData { Name="[优惠平台]优惠券已使用", Value= 212},
                new SerieData { Name="[度假]优惠券在当前订单没有匹配的阶梯", Value= 201},
                new SerieData { Name="[度假]该产品不可以使用该优惠券", Value= 170},
                new SerieData { Name="[优惠平台]使用次数超过策略允许最大值", Value= 107},
                new SerieData { Name="[度假]订单原始金额(orderAmount)必须是正数", Value= 97},
                new SerieData { Name="[优惠平台]优惠券不存在", Value= 58},
                new SerieData { Name="[优惠平台]风控屏蔽！", Value= 38},
                new SerieData { Name="[优惠平台]产线ID与策略不匹配", Value= 24},
                new SerieData { Name="[度假]优惠券在当前平台(platformId)不可用", Value= 22},
                new SerieData { Name="[优惠平台]优惠券所属适用站点不匹配", Value= 19},
                new SerieData { Name="[度假]优惠券在当前渠道不可用", Value= 17},
                new SerieData { Name="[优惠平台]该限时优惠券已被其他用户收藏", Value= 12},
                new SerieData { Name="[优惠平台]券码不合法", Value= 5},
                new SerieData { Name="[度假]用户信息(UserInfo)必传", Value= 3},
                new SerieData { Name="[度假]这张订单想要优惠的金额太多了", Value= 3},
                new SerieData { Name="[度假]优惠券没有被设置", Value= 2},
                new SerieData { Name="[优惠平台]优惠券已经失效", Value= 1},
                new SerieData { Name="[优惠平台]活动已经结束了", Value= 1}
            };


            return option;
        }
    }
}