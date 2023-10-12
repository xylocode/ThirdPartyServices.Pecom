using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.Pecom.Helpers
{
    internal class JsonStringAsNIntConverter : JsonConverter<int?>
    {
        public override int? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var s = reader.GetString();
            if (int.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out int result))
                return result;
            return null;
        }

        public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteNumberValue(value.Value);
        }
    }

}
