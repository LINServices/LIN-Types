using LIN.Types.Enumerations;

namespace LIN.Types.Notes.Models;

public class NoteDataModel
{
    public int Id { get; set; } = 0;
    public string Tittle { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public NoteType Origin { get; set; }
    public List<TaskDataModel> Tasks { get; set; } = [];
    public int Color { get; set; }
    public DateTime LastUpdate { get; set; }
    public Languages Language { get; set; }
    public List<NoteAccessDataModel> UsersAccess { get; set; } = [];
}