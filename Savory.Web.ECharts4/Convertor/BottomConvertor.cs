using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4.Convertor
{
    public class BottomConvertor : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Bottom);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Bottom bottom = value as Bottom;
            if (bottom == null)
            {
                return;
            }

            if (bottom.IntValue != null)
            {
                if (bottom.IsPercent)
                {
                    writer.WriteValue(bottom.IntValue + "%");
                }
                else
                {
                    writer.WriteValue(bottom.IntValue);
                }
            }
        }

    }
}
