using LIN.RabbitMQ.Types.Contracts;

namespace LIN.Types.Cloud.Edge.RequestModels;

[IntegrationEvent("save_error")]
public record ResourceProvisioningStatus(int Resource, string Message, bool ShouldRetryLater) : IntegrationEvent;
