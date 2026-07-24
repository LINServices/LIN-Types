using LIN.RabbitMQ.Types.Contracts;

namespace LIN.Types.Developer.BusModels;

[IntegrationEvent("lco_billing_charge")]
public record BillingChargeBusModel(int ResourceId,
    decimal Amount,
    string Message,
    DateTime PeriodStartUtc,
    DateTime PeriodEndUtc) : IntegrationEvent;