using LIN.Types.Developer.Models;

namespace LIN.Types.Developer.Interfaces;


public interface IProjectKey : IProjectModel
{

    public List<ApiKeyDataModel> Keys { get; set; }

}
