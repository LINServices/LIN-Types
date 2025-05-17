using LIN.Types.Developer.Models;

namespace LIN.Types.Developer.TransactionModels;

public class NewResourceModel<T> where T : new()
{
    public string Key { get; set; } = string.Empty;
    public string TokenCloud { get; set; } = string.Empty;
    public ProjectDataModel Resource { get; set; } = default!;
    public Dictionary<string, string> Parameters { get; set; } = [];
    public T Value { get; set; } = default!;
}