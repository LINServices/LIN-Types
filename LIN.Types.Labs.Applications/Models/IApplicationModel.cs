namespace LIN.Types.Labs.Applications.Models;


public interface IApplicationModel
{

    public string Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public bool AllowAnyPerson { get; set; }
    public List<int> AccountsIds { get; set; }

}