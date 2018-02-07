﻿using Newtonsoft.Json;
using Savory.Web.ECharts4;
using Savory.Web.ECharts4.Convertor;
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

            var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            settings.Converters.Add(new LeftConvertor());

            var content = JsonConvert.SerializeObject(option, Formatting.Indented, settings);

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