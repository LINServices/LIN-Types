﻿namespace LIN.Types.Developer.Models;


public class FirewallRuleDataModel
{

    public int ID { get; set; }

    public string RuleName { get; set; } = string.Empty;

    public string IPInicio { get; set; } = string.Empty;

    public string IPFinal { get; set; } = string.Empty;

    public ProjectDataModel Project { get; set; }

    public FirewallRuleStatus Status { get; set; } = FirewallRuleStatus.Undefined;

}