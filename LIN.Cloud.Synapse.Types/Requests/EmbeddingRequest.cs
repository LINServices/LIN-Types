using System.ComponentModel.DataAnnotations;

namespace LIN.Cloud.Synapse.Types.Requests;

public class EmbeddingRequest
{
    [Required]
    public string Model { get; set; } = string.Empty;

    [Required]
    [MinLength(1)]
    public List<string> Input { get; set; } = new();
}
