using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace LIN.Cloud.Synapse.Types.Requests;

/// <summary>
/// A tool the model is allowed to invoke. Declared by the caller on each request:
/// Synapse holds no tool registry and never executes anything itself.
/// </summary>
public class ToolDefinition
{
    /// <summary>Only "function" is supported today.</summary>
    [Required]
    public string Type { get; set; } = "function";

    [Required]
    public FunctionDefinition Function { get; set; } = new();
}

public class FunctionDefinition
{
    [Required]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Shown to the model to decide when to call this function. Worth writing carefully:
    /// it drives invocation accuracy more than the schema does.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// JSON Schema describing the arguments. Kept as a raw JSON element so the schema
    /// travels to the provider untouched, whatever shape it has.
    /// </summary>
    public JsonElement? Parameters { get; set; }
}
