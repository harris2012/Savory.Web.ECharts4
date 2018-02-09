using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    /// <summary>
    /// 组件离容器左侧的距离
    /// 可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'left', 'center', 'right'
    /// </summary>
    public class Left
    {
        public int? IntValue { get; private set; }
        public bool IsPercent { get; private set; }
        public LeftEnum? EnumValue { get; private set; }

        public Left(int intValue) : this(intValue, false)
        {
        }

        public Left(int intValue, bool isPercent)
        {
            this.IntValue = intValue;
            this.IsPercent = isPercent;
        }

        public Left(float floatValue)
        {
            this.IntValue = (int)(floatValue * 100);
            this.IsPercent = true;
        }

        public Left(double floatValue)
        {
            this.IntValue = (int)(floatValue * 100);
            this.IsPercent = true;
        }

        public Left(LeftEnum leftEnum)
        {
            this.EnumValue = leftEnum;
        }

        public static implicit operator Left(LeftEnum enumValue)
        {
            return new Left(enumValue);
        }

        public static implicit operator Left(int intValue)
        {
            return new Left(intValue);
        }

        public static implicit operator Left(float floatValue)
        {
            return new Left(floatValue);
        }

        public static implicit operator Left(double doubleValue)
        {
            return new Left(doubleValue);
        }
    }
}
