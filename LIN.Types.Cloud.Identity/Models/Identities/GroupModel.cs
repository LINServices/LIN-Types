﻿namespace LIN.Types.Cloud.Identity.Models.Identities;

public class GroupModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool IsDefault { get; set; }
    public List<GroupMember> Members { get; set; } = [];
    public IdentityModel Identity { get; set; } = null!;
    public int IdentityId { get; set; }
}