namespace LIN.Types.Calendar.Models;

public class ProfileModel
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Creation { get; set; }
}