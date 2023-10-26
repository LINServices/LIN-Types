using LIN.Types.Developer.Models;

namespace LIN.Types.Developer.Interfaces;


public interface IProjectApplication : IProjectModel
{

    public string AppKey { get; set; }

}
