using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Savory.Web.ECharts4.DemoProject
{
    public class ExampleAttribute : Attribute
    {
        public string Title { get; private set; }

        public ExampleAttribute(string title)
        {
            this.Title = title;
        }
    }
}