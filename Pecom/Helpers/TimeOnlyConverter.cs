﻿using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.Pecom.Helpers
{
    internal class TimeOnlyConverter : JsonConverter<TimeOnly>
    {
        public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            TimeOnly result;
            var s = reader.GetString();
            
            if (TimeOnly.TryParseExact(s, "HH:mm:ss", out result))
                return result;

            if (TimeOnly.TryParseExact(s, "HH:mm", out result))
                return result;

            if (TimeOnly.TryParseExact(s, "0001-01-01THH:mm:ss", out result))
                return result;

            throw new Exception(s);
        }

        public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("HH:mm"));
        }
    }
}
