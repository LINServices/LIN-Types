namespace LIN.Types.Developer.Interfaces;


public interface IProjectDB : IProjectModel
{
    public string ConnectionString { get; set; }

}