using Newtonsoft.Json;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Http.Extensions.Json;

internal sealed class JsonElementNewtonsoftConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
        => objectType == typeof(JsonElement) || objectType == typeof(JsonElement?);

    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        if (value is JsonElement element && element.ValueKind != JsonValueKind.Undefined)
        {
            writer.WriteRawValue(element.GetRawText());
        }
        else
        {
            writer.WriteNull();
        }
    }

    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null)
        {
            return objectType == typeof(JsonElement?) ? null : default(JsonElement);
        }

        var token = Newtonsoft.Json.Linq.JToken.Load(reader);
        using var document = JsonDocument.Parse(token.ToString(Formatting.None));
        return document.RootElement.Clone();
    }
}