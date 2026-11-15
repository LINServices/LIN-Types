using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LIN.Cloud.Synapse.Types.Requests;

/// <summary>
/// Shape the model must give its answer. Mirrors OpenAI's <c>response_format</c>.
/// </summary>
public class ResponseFormat
{
    public const string TypeText = "text";
    public const string TypeJsonObject = "json_object";
    public const string TypeJsonSchema = "json_schema";

    /// <summary>
    /// "text" (default), "json_object" (any valid JSON; requires <c>ModelCapability.JsonOutput</c>
    /// and the word "json" somewhere in the messages) or "json_schema" (JSON matching
    /// <see cref="JsonSchema"/>; requires <c>ModelCapability.JsonSchema</c>).
    /// </summary>
    [Required]
    public string Type { get; set; } = TypeText;

    /// <summary>Required when <see cref="Type"/> is "json_schema"; ignored otherwise.</summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public JsonSchemaFormat? JsonSchema { get; set; }
}

public class JsonSchemaFormat
{
    /// <summary>Identifier for the schema: letters, digits, '_' or '-', up to 64 characters.</summary>
    [Required]
    public string Name { get; set; } = string.Empty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Description { get; set; }

    /// <summary>
    /// JSON Schema the answer must match. Kept as a raw JSON element so it travels to the
    /// provider untouched.
    /// </summary>
    public JsonElement? Schema { get; set; }

    /// <summary>
    /// True asks the provider to enforce the schema exactly (OpenAI then requires every property
    /// in <c>required</c> and <c>additionalProperties: false</c>). Null leaves the provider default.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Strict { get; set; }
}
