namespace LIN.Types.Cloud.Identity.Platform.Access;

public record TimeRule(List<DayOfWeek> Days, TimeOnly StartTime, TimeOnly EndTime);
