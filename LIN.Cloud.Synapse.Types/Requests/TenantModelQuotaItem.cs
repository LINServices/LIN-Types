using System.ComponentModel.DataAnnotations;
using LIN.Cloud.Synapse.Types.Enums;

namespace LIN.Cloud.Synapse.Types.Requests;

public class TenantModelQuotaItem
{
    [Required]
    public QuotaPeriod? Period { get; set; }

    public long? MaxInputTokens { get; set; }

    public long? MaxOutputTokens { get; set; }
}
