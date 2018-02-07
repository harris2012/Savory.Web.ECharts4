using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4.RunExample
{
    class Program
    {
        static void Main(string[] args)
        {
            EChartsOption option = new EChartsOption();

            var content = EChartsConvert.Serialize(option);

            File.WriteAllText(@"F:\1.txt", content);
        }
    }
}
