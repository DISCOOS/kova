using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace kova.api.Models
{
    public class PoiConverter : JsonConverter
    {
        public override bool CanRead => false;
        public override bool CanWrite => true;

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TOrganizationPoi);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is TOrganizationPoi)
            {
                var jsonObject = createPlainJsonObject(value, serializer);
                var position = jsonObject.GetValue("position").Value<string>();
                var longLat = GetLatLongFromPoint(position);
                jsonObject.Remove("position");
                jsonObject.Add("position", JToken.FromObject(new
                {
                    lat = longLat[0],
                    @long = longLat[1]
                }));
                jsonObject.WriteTo(writer);
            }
        }

        private double[] GetLatLongFromPoint(string position)
        {
            // POINT (6.07363 59.64445)
            int start = position.IndexOf('(');
            int end = position.IndexOf(')');
            var elements = position.Substring(start + 1, end - start - 1).Trim().Split(' ');
            return new double[] {
                double.Parse(elements[0], NumberFormatInfo.InvariantInfo),
                double.Parse(elements[1], NumberFormatInfo.InvariantInfo)
            };
        }

        private JObject createPlainJsonObject(object value, JsonSerializer serializer)
        {
            JObject jsonObject = new JObject();

            foreach (PropertyInfo property in value.GetType().GetProperties())
            {
                if (property.CanRead && property.GetCustomAttribute<JsonIgnoreAttribute>() == null)
                {
                    object propertyValue = property.GetValue(value);
                    if (propertyValue != null)
                    {
                        jsonObject.Add(camelCase(property.Name), JToken.FromObject(propertyValue, serializer));
                    }
                }
            }

            return jsonObject;
        }

        private string camelCase(string name)
        {
            return name[0].ToString().ToLower() + name.Substring(1);
        }

    }
}
