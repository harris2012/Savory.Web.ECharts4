using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    /// <summary>
    /// 组件离容器下侧的距离。
    /// 可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。
    /// </summary>
    public class Bottom
    {
        public int? IntValue { get; private set; }
        public bool IsPercent { get; private set; }

        public Bottom(int leftValue) : this(leftValue, false)
        {
        }

        public Bottom(int leftValue, bool isPercent)
        {
            this.IntValue = leftValue;
            this.IsPercent = isPercent;
        }

        public Bottom(float floatValue)
        {
            this.IntValue = (int)(floatValue * 100);
            this.IsPercent = true;
        }

        public Bottom(double doubleValue)
        {
            this.IntValue = (int)(doubleValue * 100);
            this.IsPercent = true;
        }

        public static implicit operator Bottom(int intValue)
        {
            return new Bottom(intValue);
        }

        public static implicit operator Bottom(float floatValue)
        {
            return new Bottom(floatValue);
        }

        public static implicit operator Bottom(double doubleValue)
        {
            return new Bottom(doubleValue);
        }
    }
}
