using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.Pecom.Helpers
{
    internal class JsonStringAsDayOfWeekConverter : JsonConverter<Enums.DayOfWeek>
    {
        public override Enums.DayOfWeek Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var s = reader.GetString();
            if (byte.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out byte result))
                return (Enums.DayOfWeek)result;
         
            return (Enums.DayOfWeek)0;
        }

        public override void Write(Utf8JsonWriter writer, Enums.DayOfWeek value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue((byte)value);
        }
    }

}
