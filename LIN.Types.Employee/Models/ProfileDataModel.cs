﻿using LIN.Types.Employee.Enumerations;

namespace LIN.Types.Employee.Models;


/// <summary>
/// Modelo
/// </summary>
public class ProfileDataModel : IProfile
{

    public int Id { get; set; } = 0;
    public DateTime Creación { get; set; }
    public ProfileStatus Estado { get; set; } = ProfileStatus.Normal;
    public int OrganizationID { get; set; } = 0;
    public int AccountId { get; set; } = 0;
    public List<TeamAccessModel> Teams { get; set; } = [];
    public DateTime Creation { get; set; }
}
