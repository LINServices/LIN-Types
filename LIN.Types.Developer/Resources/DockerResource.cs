namespace LIN.Types.Developer.Resources;

public class DockerResource : Models.ProjectDataModel
{
    public int Cpu { get; set; }
    public int MaxMemory { get; set; }
    public DockerProjectStatus ContainerStatus { get; set; } = DockerProjectStatus.None;
    public List<BindingModel> Bindings { get; set; } = [];
}