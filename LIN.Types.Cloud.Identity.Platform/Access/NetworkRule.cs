namespace LIN.Types.Cloud.Identity.Platform.Access;

public record NetworkRule(List<string> IpWhitelist, List<string> IpBlacklist, List<string> AllowedCountries);
