﻿using LIN.Developer.Types.Enumerations;

namespace LIN.Developer.Types.Models;


public class FirewallRuleDataModel
{

    public int ID { get; set; }

    public string RuleName { get; set; } = string.Empty;

    public string IPInicio { get; set; } = string.Empty;

    public string IPFinal { get; set; } = string.Empty;

    public int ProjectID { get; set; }

    public FirewallRuleStatus Status { get; set; } = FirewallRuleStatus.Undefined;

}
