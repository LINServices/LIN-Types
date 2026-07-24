using LIN.RabbitMQ.Types.Contracts;
using LIN.Types.Developer.BillingModels;

namespace LIN.Types.Developer.BusModels;

[IntegrationEvent("confirm_subscription")]
public record ConfirmSubscriptionBusModel(int ResourceId, decimal Amount, SubscriptionType Type, BillingUnit Unit) : IntegrationEvent;

[IntegrationEvent("subscription_renovation")]
public record ConfirmRenovationBusModel(int ResourceId, decimal Amount, SubscriptionType Type, BillingUnit Unit) : IntegrationEvent;
