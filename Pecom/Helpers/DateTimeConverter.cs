using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.Pecom.Helpers
{
    internal class DateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            DateTime dateTime;
            var s = reader.GetString();

            if (DateTime.TryParseExact(s, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
                return dateTime;

            // С буквой T!!!
            if (DateTime.TryParseExact(s, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
                return dateTime;

            
            throw new NotImplementedException(s);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
