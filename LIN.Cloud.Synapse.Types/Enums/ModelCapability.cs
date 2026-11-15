namespace LIN.Cloud.Synapse.Types.Enums;

[Flags]
public enum ModelCapability
{
    None = 0,
    Chat = 1,
    Completion = 2,
    Embedding = 4,

    /// <summary>Model can be given tools to invoke. Implies, but does not include, Chat.</summary>
    ToolUse = 8,

    /// <summary>Model can turn audio into text.</summary>
    Transcription = 16,

    /// <summary>Model can be forced to answer with valid JSON (response format "json_object").</summary>
    JsonOutput = 32,

    /// <summary>Model can be forced to answer with JSON matching a schema (response format "json_schema").</summary>
    JsonSchema = 64
}
