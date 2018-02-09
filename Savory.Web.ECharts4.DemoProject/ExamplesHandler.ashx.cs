using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject
{
    /// <summary>
    /// ExamplesHandler 的摘要说明
    /// </summary>
    public class ExamplesHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";

            var content = JsonConvert.SerializeObject(ExampleProvider.GetExamples());

            context.Response.Write(content);
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