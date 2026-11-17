using System.ComponentModel.DataAnnotations;
using LIN.Cloud.Synapse.Types.Enums;

namespace LIN.Cloud.Synapse.Types.Requests;

/// <summary>
/// Límite propio del tenant en un periodo; anula el límite por defecto del modelo en ese periodo.
/// Con ambos máximos en null el tenant queda sin límite en ese periodo.
/// </summary>
public class TenantModelQuotaItem
{
    [Required]
    public QuotaPeriod? Period { get; set; }

    public long? MaxInputTokens { get; set; }

    public long? MaxOutputTokens { get; set; }
}
