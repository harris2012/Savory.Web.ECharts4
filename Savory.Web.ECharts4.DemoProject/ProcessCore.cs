using Newtonsoft.Json;
using Savory.Web.ECharts4.Convertor;
using Savory.Web.ECharts4.DemoProject.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject
{
    public class ProcessCore
    {
        public static string Run(string id)
        {
            ProcessorBase processor = null;

            var types = typeof(ExampleAttribute).Assembly.GetTypes();
            foreach (var type in types)
            {
                if (type.IsDefined(typeof(ExampleAttribute), false) && type.Name.Equals(id))
                {
                    processor = (ProcessorBase)Activator.CreateInstance(type);
                    break;
                }
            }

            if (processor != null)
            {
                var option = processor.GetOption();

                var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
                settings.Converters.Add(new LeftConvertor());
                settings.Converters.Add(new RightConvertor());
                settings.Converters.Add(new TopConvertor());
                settings.Converters.Add(new BottomConvertor());
                settings.Converters.Add(new AxisTypeConvertor());
                settings.Converters.Add(new SerieTypeConvertor());
                settings.Converters.Add(new SerieDataCollectionConvertor());
                settings.Converters.Add(new TitleCollectionConvertor());
                settings.Converters.Add(new XAxisCollectionConvertor());
                settings.Converters.Add(new YAxisCollectionConvertor());
                settings.Converters.Add(new GridCollectionConvertor());
                settings.Converters.Add(new LabelMapConvertor());

                return JsonConvert.SerializeObject(option, Formatting.Indented, settings);
            }
            else
            {
                return "{\"message\":\"id is null or not supported.\"}";
            }
        }
    }
}