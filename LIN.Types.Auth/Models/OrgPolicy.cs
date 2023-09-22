namespace LIN.Types.Auth.Models;


public class OrgPolicy
{

    public int ID { get; set; }
    public bool VisibleMembers { get; set; }
    public OrganizationModel Organization { get; set; }
    public TimeSpan TokenExpiration { get; set; } = TimeSpan.FromHours(5);

}