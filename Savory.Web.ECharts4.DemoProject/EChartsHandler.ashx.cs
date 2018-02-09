using Newtonsoft.Json;
using Savory.Web.ECharts4.Convertor;
using Savory.Web.ECharts4.DemoProject.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject
{
    /// <summary>
    /// EChartsHandler 的摘要说明
    /// </summary>
    public class EChartsHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";

            var id = context.Request.QueryString["id"];

            context.Response.Write(ProcessCore.Run(id));
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