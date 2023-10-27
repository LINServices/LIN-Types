using LIN.Types.Developer.Models;

namespace LIN.Types.Developer.Interfaces;


public interface IProjectKey : IProjectModel
{

    public List<KeyModel> Keys { get; set; }

}
