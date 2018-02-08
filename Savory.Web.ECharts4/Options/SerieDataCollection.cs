using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class SerieDataCollection
    {
        public List<SerieData> SerieDataList { get; private set; }

        public static implicit operator SerieDataCollection(List<SerieData> serieDataList)
        {
            SerieDataCollection returnValue = new SerieDataCollection();

            returnValue.SerieDataList = serieDataList;

            return returnValue;
        }

        public static implicit operator SerieDataCollection(List<int> serieDataList)
        {
            SerieDataCollection returnValue = new SerieDataCollection();

            returnValue.SerieDataList = serieDataList.Select(v => new SerieData { Value = v }).ToList();

            return returnValue;
        }
    }
}
