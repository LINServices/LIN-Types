namespace LIN.Types.Notes.Models;


public class NoteDataModel
{

    public int Id { get; set; } = 0;
    public string Tittle { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;


    public List<NoteAccessDataModel> UsersAccess { get; set; } = new();


}