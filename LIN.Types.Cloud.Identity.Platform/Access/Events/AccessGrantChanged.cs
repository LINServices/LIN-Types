namespace LIN.Types.Cloud.Identity.Platform.Access.Events;

public record AccessGrantChanged(string ObjectId, int IdentityId, int ApplicationId, AccessGrantChangeKind Kind, DateTime OccurredAt);
