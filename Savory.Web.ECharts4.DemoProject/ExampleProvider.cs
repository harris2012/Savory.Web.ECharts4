using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject
{
    public class ExampleProvider
    {
        public static List<string> GetIds()
        {
            List<string> returnValue = new List<string>();

            var types = typeof(ExampleAttribute).Assembly.GetTypes();
            foreach (var type in types)
            {
                if (type.IsDefined(typeof(ExampleAttribute), false))
                {
                    returnValue.Add(type.Name);
                }
            }

            return returnValue;
        }

        public static List<Example> GetExamples()
        {
            List<Example> returnValue = new List<Example>();

            var types = typeof(ExampleAttribute).Assembly.GetTypes();
            foreach (var type in types)
            {
                if (type.IsDefined(typeof(ExampleAttribute), false))
                {
                    var exampleAttribute = (ExampleAttribute)type.GetCustomAttribute(typeof(ExampleAttribute), false);

                    Example example = new Example { Name = type.Name, Title = exampleAttribute.Title };

                    returnValue.Add(example);
                }
            }

            return returnValue.OrderBy(v => v.Name).ToList();
        }
    }
}