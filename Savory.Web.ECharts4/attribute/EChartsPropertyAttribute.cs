using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class EChartsPropertyAttribute : Attribute
    {
        public string Name { get; private set; }

        public EChartsPropertyAttribute(string name)
        {
            this.Name = name;
        }
    }
}
