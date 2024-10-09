namespace LIN.Types.Developer.Models;

public class KeyModel
{

    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = string.Empty;

    [Column("api_key")]
    public string Key { get; set; } = string.Empty;

    [Column("state")]
    public ApiKeyStatus Status { get; set; } = ApiKeyStatus.Active;

    [Column("project_fk")]
    public int ProjectId { get; set; }

    public ProjectDataModel Project { get; set; } = null!;

}