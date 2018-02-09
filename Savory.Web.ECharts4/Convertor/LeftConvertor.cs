using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4.Convertor
{
    public class LeftConvertor : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Left);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Left left = value as Left;
            if (left == null)
            {
                return;
            }

            if (left.EnumValue != null)
            {
                switch (left.EnumValue.Value)
                {
                    case LeftEnum.Left:
                        writer.WriteValue("left");
                        break;
                    case LeftEnum.Center:
                        writer.WriteValue("center");
                        break;
                    case LeftEnum.Right:
                        writer.WriteValue("right");
                        break;
                    default:
                        break;
                }
            }
            else if (left.IntValue != null)
            {
                if (left.IsPercent)
                {
                    writer.WriteValue(left.IntValue + "%");
                }
                else
                {
                    writer.WriteValue(left.IntValue);
                }
            }
        }

    }
}
