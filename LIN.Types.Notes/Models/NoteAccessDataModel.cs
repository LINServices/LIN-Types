namespace LIN.Types.Notes.Models;

public class NoteAccessDataModel
{
    public int Id { get; set; } = 0;
    public NoteAccessState State { get; set; }
    public DateTime Fecha { get; set; }
    public ProfileModel Profile { get; set; } = null!;
    public int ProfileID { get; set; }
    public NoteDataModel Note { get; set; } = null!;
    public int NoteId { get; set; }

}