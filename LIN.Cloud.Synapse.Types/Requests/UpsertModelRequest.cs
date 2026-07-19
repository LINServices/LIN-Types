using LIN.Cloud.Synapse.Types.Enums;
using System.ComponentModel.DataAnnotations;

namespace LIN.Cloud.Synapse.Types.Requests;

public class UpsertModelRequest
{
    [Required]
    public string ModelId { get; set; } = string.Empty;

    [Required]
    public string Provider { get; set; } = string.Empty;

    [Required]
    public string ProviderModelName { get; set; } = string.Empty;

    [Required]
    public ModelCapability Capabilities { get; set; }

    public bool IsEnabled { get; set; } = true;

    [Range(0, double.MaxValue)]
    public decimal InputPricePerMillionTokens { get; set; }

    [Range(0, double.MaxValue)]
    public decimal OutputPricePerMillionTokens { get; set; }
}
