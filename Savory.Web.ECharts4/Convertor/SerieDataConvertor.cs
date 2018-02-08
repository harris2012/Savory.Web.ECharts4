﻿using Newtonsoft.Json;
using Savory.Web.ECharts4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4.Convertor
{
    public class SerieDataConvertor : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(SerieData);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            SerieData serieData = value as SerieData;
            if (serieData == null)
            {
                return;
            }
            if (serieData.Name == null)
            {
                writer.WriteValue(serieData.Value);
            }
            else
            {
                var itemString = JsonConvert.SerializeObject(serieData);

                writer.WriteValue(itemString);
            }
        }
    }
}
