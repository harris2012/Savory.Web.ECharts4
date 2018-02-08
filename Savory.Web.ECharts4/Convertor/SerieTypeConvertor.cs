using Newtonsoft.Json;
using Savory.Web.ECharts4.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4.Convertor
{
    public class SerieTypeConvertor : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(SerieType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            SerieType serieType = value as SerieType;
            if (serieType == null)
            {
                return;
            }

            switch (serieType.SerieTypeEnum)
            {
                case SerieTypeEnum.Line:
                    writer.WriteValue("line");
                    break;
                case SerieTypeEnum.Bar:
                    writer.WriteValue("bar");
                    break;
                case SerieTypeEnum.Pie:
                    writer.WriteValue("pie");
                    break;
                default:
                    throw new NotSupportedException();
            }

        }
    }
}
