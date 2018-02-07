using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject
{
    /// <summary>
    /// LegendDataHandler 的摘要说明
    /// </summary>
    public class LegendDataHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";

            List<string> legendData = new List<string>
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

            context.Response.Write(JsonConvert.SerializeObject(legendData));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}