﻿using Newtonsoft.Json;
using Savory.Web.ECharts4;
using Savory.Web.ECharts4.Convertor;
using Savory.Web.ECharts4.DemoProject.BizOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject
{
    /// <summary>
    /// EChartsHandler 的摘要说明
    /// </summary>
    public class EChartsOptionHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";

            OptionProcessorBase processor = null;

            var id = context.Request.QueryString["id"];
            switch (id)
            {
                case "firstexample":
                    processor = new FirstExampleProcessor();
                    break;
                default:
                    break;
            }

            if (processor != null)
            {
                var option = processor.GetOption();

                var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
                settings.Converters.Add(new LeftConvertor());

                var content = JsonConvert.SerializeObject(option, Formatting.Indented, settings);

                context.Response.Write(content);
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