namespace LIN.Cloud.Synapse.Types.Responses;

public class TranscriptionResponse
{
    public string Model { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;

    /// <summary>Idioma detectado (ISO-639-1) cuando el proveedor lo informa.</summary>
    public string? Language { get; set; }

    /// <summary>Duración del audio en segundos cuando el proveedor la informa.</summary>
    public double? DurationSeconds { get; set; }

    /// <summary>
    /// Modelos facturados por tokens reportan tokens de audio y de texto; los facturados por
    /// duración reportan los segundos de audio como <see cref="UsageInfo.InputTokens"/>.
    /// </summary>
    public UsageInfo Usage { get; set; } = new();
}
