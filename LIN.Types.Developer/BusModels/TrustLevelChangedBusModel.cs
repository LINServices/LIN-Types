using LIN.RabbitMQ.Types.Contracts;
using LIN.Types.Developer.Enumerations;

namespace LIN.Types.Developer.BusModels;

[IntegrationEvent("lco_trust_level_changed")]
public record TrustLevelChangedBusModel(int BillingAccountId,
    BillingPlan Plan,
    int TrustLevel,
    DateTime ChangedAt) : IntegrationEvent;
