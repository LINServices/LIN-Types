using System.ComponentModel.DataAnnotations;
using LIN.Cloud.Synapse.Types.Enums;

namespace LIN.Cloud.Synapse.Types.Requests;

/// <summary>
/// Límite de tokens por defecto de un modelo en un periodo; se aplica a los tenants sin límite propio en ese periodo.
/// </summary>
public class ModelDefaultQuotaItem
{
    [Required]
    public QuotaPeriod? Period { get; set; }

    public long? MaxInputTokens { get; set; }

    public long? MaxOutputTokens { get; set; }
}
