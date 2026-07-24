using System.ComponentModel.DataAnnotations;

namespace LIN.Cloud.Synapse.Types.Requests;

/// <summary>
/// An invocation the model asked for. Returned inside the assistant message, and echoed
/// back by the caller as the <see cref="ChatMessage.ToolCallId"/> of the result message.
/// </summary>
public class ToolCall
{
    /// <summary>
    /// Correlates this invocation with its result. Providers that do not emit one
    /// (Google) get a synthetic id assigned by the gateway.
    /// </summary>
    [Required]
    public string Id { get; set; } = string.Empty;

    /// <summary>Only "function" is supported today.</summary>
    public string Type { get; set; } = "function";

    [Required]
    public FunctionCall Function { get; set; } = new();
}

public class FunctionCall
{
    [Required]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Arguments as a JSON-encoded <b>string</b>, not an object. Models occasionally emit
    /// malformed JSON here; it is carried through verbatim so the caller decides how to
    /// handle it rather than the gateway failing the whole response.
    /// </summary>
    public string Arguments { get; set; } = "{}";
}
