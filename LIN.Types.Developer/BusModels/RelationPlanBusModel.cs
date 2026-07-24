using LIN.RabbitMQ.Types.Contracts;

namespace LIN.Types.Developer.BusModels;

[IntegrationEvent("plan_changed")]
public record RelationPlanBusModel(int ResourceId, int? PlanId) : IntegrationEvent;
