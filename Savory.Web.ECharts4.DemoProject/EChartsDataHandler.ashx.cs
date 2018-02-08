using Newtonsoft.Json;
using Savory.Web.ECharts4.DemoProject.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject
{
    /// <summary>
    /// EChartsDataHandler 的摘要说明
    /// </summary>
    public class EChartsDataHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            var id = context.Request.QueryString["id"];

            DataProcessorBase processor = null;

            switch (id)
            {
                case "firstexample":
                    processor = new FirstExampleProcessor();
                    break;
                default:
                    break;
            }

            context.Response.ContentType = "application/json";

            if (processor != null)
            {
                var item = processor.Process();

                context.Response.Write(JsonConvert.SerializeObject(item));
            }
            else
            {
                context.Response.Write("{\"message\":\"id is null or not supported.\"}");
            }
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