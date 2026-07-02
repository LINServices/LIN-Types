namespace LIN.Types.Notes.Models;

public class MovementDataModel
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public MovementType Type { get; set; }
    public DateTime Date { get; set; }

    public ProfileModel Profile { get; set; } = null!;
    public int ProfileId { get; set; }
}