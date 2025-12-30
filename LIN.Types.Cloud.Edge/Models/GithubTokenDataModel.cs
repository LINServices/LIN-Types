namespace LIN.Types.Cloud.Edge.Models;

public class GithubTokenDataModel
{
    public int Id { get; set; }
    public string GithubToken { get; set; } = string.Empty;
    public long GithubUserId { get; set; }
    public DateTime ExpirexAt { get; set; }
}