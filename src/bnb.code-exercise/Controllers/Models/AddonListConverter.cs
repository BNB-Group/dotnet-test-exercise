using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using static Bnb.CodeExercise.Controllers.Models.CalculateMonthlyPaymentRequestModel;
namespace Bnb.CodeExercise.Controllers.Models;

public class AddonListSystemTextJsonConverter : JsonConverter<Addon[]>
{
    public override Addon[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = new List<Addon>();

        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException("Expected StartArray token");

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndArray)
                break;

            if (reader.TokenType != JsonTokenType.String)
                throw new JsonException("Expected string value in addons array");

            var str = reader.GetString();
            var parts = str.Split(':', 2);

            if (parts.Length == 1)
            {
                result.Add(new Addon { Type = parts[0] });
            }
            else if (parts.Length == 2 && decimal.TryParse(parts[1], out var value))
            {
                result.Add(new Addon { Type = parts[0], Value = value });
            }
            else
            {
                throw new JsonException($"Invalid addon format: {str}");
            }
        }

        return result.ToArray();
    }

    public override void Write(Utf8JsonWriter writer, Addon[] value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        foreach (var addon in value)
        {
            if (addon.Value.HasValue)
                writer.WriteStringValue($"{addon.Type}:{addon.Value}");
            else
                writer.WriteStringValue(addon.Type);
        }
        writer.WriteEndArray();
    }
}