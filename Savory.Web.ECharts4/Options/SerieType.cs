using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class SerieType
    {
        public static SerieType Line { get; set; } = new SerieType(SerieTypeEnum.Line);
        public static SerieType Bar { get; set; } = new SerieType(SerieTypeEnum.Bar);
        public static SerieType Pie { get; set; } = new SerieType(SerieTypeEnum.Pie);

        public SerieTypeEnum SerieTypeEnum { get; private set; }

        private SerieType(SerieTypeEnum serieTypeEnum)
        {
            this.SerieTypeEnum = serieTypeEnum;
        }

        public static implicit operator SerieType(SerieTypeEnum serieTypeEnum)
        {
            switch (serieTypeEnum)
            {
                case SerieTypeEnum.Line:
                    return Line;
                case SerieTypeEnum.Bar:
                    return Bar;
                case SerieTypeEnum.Pie:
                    return Pie;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
