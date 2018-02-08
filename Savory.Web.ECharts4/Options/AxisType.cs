using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4.Options
{
    /// <summary>
    /// 坐标轴类型。
    /// </summary>
    public class AxisType
    {
        public static AxisType Value { get; set; } = new AxisType(AxisTypeEnum.Value);
        public static AxisType Category { get; set; } = new AxisType(AxisTypeEnum.Category);
        public static AxisType Time { get; set; } = new AxisType(AxisTypeEnum.Time);
        public static AxisType Log { get; set; } = new AxisType(AxisTypeEnum.Log);

        public AxisTypeEnum AxisTypeEnum { get; private set; }

        private AxisType(AxisTypeEnum axisTypeEnum)
        {
            this.AxisTypeEnum = axisTypeEnum;
        }

        public static implicit operator AxisType(AxisTypeEnum axisTypeEnum)
        {
            switch (axisTypeEnum)
            {
                case AxisTypeEnum.Value:
                    return Value;
                case AxisTypeEnum.Category:
                    return Category;
                case AxisTypeEnum.Time:
                    return Time;
                case AxisTypeEnum.Log:
                    return Log;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
