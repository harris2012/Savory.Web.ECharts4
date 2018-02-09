using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class YAxisCollection
    {
        public List<YAxis> YAxisList { get; set; }

        public YAxisCollection()
        {
            this.YAxisList = new List<YAxis>();
        }

        public YAxisCollection(YAxis yAxis)
        {
            this.YAxisList = new List<YAxis> { yAxis };
        }

        public YAxisCollection(List<YAxis> yAxisList)
        {
            this.YAxisList = yAxisList;
        }

        public YAxis this[int index]
        {
            get
            {
                return this.YAxisList[index];
            }
        }

        public void Add(YAxis yAxis)
        {
            this.YAxisList.Add(yAxis);
        }

        public static implicit operator YAxisCollection(YAxis yAxis)
        {
            return new YAxisCollection(yAxis);
        }

        public static implicit operator YAxisCollection(List<YAxis> yAxisList)
        {
            return new YAxisCollection(yAxisList);
        }
    }
}
