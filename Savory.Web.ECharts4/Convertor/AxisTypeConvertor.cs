using Newtonsoft.Json;
using Savory.Web.ECharts4.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4.Convertor
{
    public class AxisTypeConvertor : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(AxisType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            AxisType axisType = value as AxisType;
            if (axisType == null)
            {
                return;
            }

            switch (axisType.AxisTypeEnum)
            {
                case AxisTypeEnum.Value:
                    writer.WriteValue("value");
                    break;
                case AxisTypeEnum.Category:
                    writer.WriteValue("category");
                    break;
                case AxisTypeEnum.Time:
                    writer.WriteValue("time");
                    break;
                case AxisTypeEnum.Log:
                    writer.WriteValue("log");
                    break;
                default:
                    throw new NotSupportedException();
            }

        }
    }
}
