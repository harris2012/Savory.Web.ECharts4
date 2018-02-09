using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4.Convertor
{
    public class TitleCollectionConvertor : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TitleCollection);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            TitleCollection collection = value as TitleCollection;
            if (collection == null || collection.TitleList == null || collection.TitleList.Count == 0)
            {
                return;
            }

            if (collection.TitleList.Count == 1)
            {
                serializer.Serialize(writer, collection.TitleList[0]);
            }
            else
            {
                serializer.Serialize(writer, collection.TitleList);
            }
        }
    }
}
