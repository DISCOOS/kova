using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace kova.api.Models
{
    public class kovaJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TOrganizationPerson);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (objectType == typeof(TOrganizationPerson))
            {
                var person = new TOrganizationPerson();
                serializer.Populate(reader, person);
                return person;
            }
            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value is TOrganizationPerson)
            {
                var jsonObject = createPlainJsonObject(value, serializer);
                jsonObject.Remove(nameof(TOrganizationPerson.Salt));
                jsonObject.Remove(nameof(TOrganizationPerson.Hash));
                jsonObject.WriteTo(writer);
            }
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
                        jsonObject.Add(property.Name, JToken.FromObject(propertyValue, serializer));
                    }
                }
            }

            return jsonObject;
        }
    }
}
