namespace LIN.Types.Developer.Projects;

public class PaymentProject : Models.ProjectDataModel
{
    public string UserName { get; set; } = string.Empty;
    public string UserMail { get; set; } = string.Empty;
    public string UserLocation { get; set; } = string.Empty;
    public bool UserAllowBilling { get; set; } = false;
    public bool UserAllowBuy { get; set; } = false;
}