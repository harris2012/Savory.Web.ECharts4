using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    /// <summary>
    /// 组件离容器上侧的距离
    /// 可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'top', 'middle', 'bottom'。
    /// 如果 top 的值为'top', 'middle', 'bottom'，组件会根据相应的位置自动对齐。
    /// </summary>
    public class Top
    {
        public int? IntValue { get; private set; }
        public bool IsPercent { get; private set; }
        public TopEnum? EnumValue { get; private set; }

        public Top(int intValue) : this(intValue, false)
        {
        }

        public Top(int intValue, bool isPercent)
        {
            this.IntValue = intValue;
            this.IsPercent = isPercent;
        }

        public Top(TopEnum enumValue)
        {
            this.EnumValue = enumValue;
        }

        public Top(float floatValue)
        {
            this.IntValue = (int)(floatValue * 100);
            this.IsPercent = true;
        }

        public Top(double floatValue)
        {
            this.IntValue = (int)(floatValue * 100);
            this.IsPercent = true;
        }

        public static implicit operator Top(TopEnum enumValue)
        {
            return new Top(enumValue);
        }

        public static implicit operator Top(int leftValue)
        {
            return new Top(leftValue);
        }

        public static implicit operator Top(float floatValue)
        {
            return new Top(floatValue);
        }

        public static implicit operator Top(double doubleValue)
        {
            return new Top(doubleValue);
        }
    }
}
