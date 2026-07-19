using System.ComponentModel.DataAnnotations;

namespace LIN.Cloud.Synapse.Types.Requests;

public class CompletionRequest
{
    [Required]
    public string Model { get; set; } = string.Empty;

    [Required]
    public string Prompt { get; set; } = string.Empty;

    public int? MaxTokens { get; set; }

    public double? Temperature { get; set; }
}
