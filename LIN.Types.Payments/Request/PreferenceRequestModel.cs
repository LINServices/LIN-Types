using LIN.Types.Payments.Models;
using System.Collections.Generic;

namespace LIN.Types.Payments.Request;

public class PreferenceRequestModel
{
    public string Document { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Webhook { get; set; } = string.Empty;
    public CurrencyEnum Currency { get; set; } = CurrencyEnum.None;
    public List<PaymentItemRequestModel> Items { get; set; } = [];
}

public enum CurrencyEnum
{
    None,
    ARS,
    BRL,
    CLP,
    MXN,
    COP,
    PEN,
    UYU
}