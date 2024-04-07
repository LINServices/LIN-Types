using LIN.Types.Notes.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Types.Notes.Models;

public class NoteAccessDataModel
{


    public int Id { get; set; } = 0;

    [Column("ESTADO")]
    public NoteAccessState State { get; set; }

    public DateTime Fecha { get; set; }


    public ProfileModel Profile { get; set; }

    [Column("PROFILE_FK")]
    public int ProfileID { get; set; }



    public NoteDataModel Note { get; set; }


    [Column("NOTE_FK")]
    public int NoteId { get; set; }





}
