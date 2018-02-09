using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    /// <summary>
    /// 可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。
    /// </summary>
    public class Right
    {
        public int? IntValue { get; private set; }
        public bool IsPercent { get; private set; }

        public Right(int leftValue) : this(leftValue, false)
        {
        }

        public Right(int leftValue, bool isPercent)
        {
            this.IntValue = leftValue;
            this.IsPercent = isPercent;
        }

        public Right(float floatValue)
        {
            this.IntValue = (int)(floatValue * 100);
            this.IsPercent = true;
        }

        public Right(double floatValue)
        {
            this.IntValue = (int)(floatValue * 100);
            this.IsPercent = true;
        }

        public static implicit operator Right(int intValue)
        {
            return new Right(intValue);
        }

        public static implicit operator Right(float floatValue)
        {
            return new Right(floatValue);
        }

        public static implicit operator Right(double doubleValue)
        {
            return new Right(doubleValue);
        }
    }
}
