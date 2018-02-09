using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject
{
    /// <summary>
    /// OutputHandler 的摘要说明
    /// </summary>
    public class OutputHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            Process(context);

            context.Response.ContentType = "application/json";
            context.Response.Write("{\"message\":\"success\"}");
        }

        private void Process(HttpContext context)
        {
            var folderPath = context.Server.MapPath("~/Output/");
            var folder = new DirectoryInfo(folderPath);
            foreach (var item in folder.GetFiles())
            {
                File.WriteAllText(item.FullName, string.Empty);
                item.Delete();
            }

            List<string> ids = ExampleProvider.GetIds();
            foreach (var id in ids)
            {
                var content = ProcessCore.Run(id);

                var path = context.Server.MapPath("~/Output/" + id + ".txt");

                File.WriteAllText(path, content);
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