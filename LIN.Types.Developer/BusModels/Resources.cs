using LIN.RabbitMQ.Types.Contracts;

namespace LIN.Types.Developer.BusModels;

[IntegrationEvent("lco_request_unable")]
public record RequestUnableResourceBusModel(int ResourceId) : IntegrationEvent;

[IntegrationEvent("lco_request_enable")]
public record RequestEnableResourceBusModel(int ResourceId) : IntegrationEvent;
