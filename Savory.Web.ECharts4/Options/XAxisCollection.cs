using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class XAxisCollection
    {
        public List<XAxis> XAxisList { get; set; }

        public XAxisCollection()
        {
            this.XAxisList = new List<XAxis>();
        }

        public XAxisCollection(XAxis xAxis)
        {
            this.XAxisList = new List<XAxis> { xAxis };
        }

        public XAxisCollection(List<XAxis> xAxisList)
        {
            this.XAxisList = xAxisList;
        }

        public XAxis this[int index]
        {
            get
            {
                return this.XAxisList[index];
            }
        }

        public void Add(XAxis xAxis)
        {
            this.XAxisList.Add(xAxis);
        }

        public static implicit operator XAxisCollection(List<XAxis> xAxisList)
        {
            return new XAxisCollection(xAxisList);
        }

        public static implicit operator XAxisCollection(XAxis xAxis)
        {
            return new XAxisCollection(xAxis);
        }
    }
}
