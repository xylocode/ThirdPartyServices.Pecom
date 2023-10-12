using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.Pecom.Helpers
{
    internal class DateOnlyConverter : JsonConverter<DateOnly>
    {
        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var s = reader.GetString();
            if (DateOnly.TryParseExact(s, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly result))
                return result;

            // С буквой T!!!
            if (DateTime.TryParseExact(s, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTime))
                return new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);

            throw new NotImplementedException(s);
        }

        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("yyyy-MM-dd"));
        }
    }
}
