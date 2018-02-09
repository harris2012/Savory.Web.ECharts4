using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class SerieType
    {
        public SerieTypeEnum SerieTypeEnum { get; private set; }

        private SerieType(SerieTypeEnum serieTypeEnum)
        {
            this.SerieTypeEnum = serieTypeEnum;
        }

        public static implicit operator SerieType(SerieTypeEnum serieTypeEnum)
        {
            return new SerieType(serieTypeEnum);
        }
    }
}
