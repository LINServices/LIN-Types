namespace LIN.Types.Notes.Models;

public class NoteAccessDataModel
{

    public int Id { get; set; } = 0;

    [Column("ESTADO")]
    public NoteAccessState State { get; set; }

    public DateTime Fecha { get; set; }

    public ProfileModel Profile { get; set; } = null!;

    [Column("PROFILE_FK")]
    public int ProfileID { get; set; }

    public NoteDataModel Note { get; set; } = null!;

    [Column("NOTE_FK")]
    public int NoteId { get; set; }

}