namespace LIN.Types.Cloud.Edge.Models;

public class VolumenDataModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ContainerDataModel Container { get; set; }
    public int ContainerId { get; set; }
}