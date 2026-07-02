using System;
using System.Collections.Generic;
using System.Text;

namespace LIN.Types.Notes.Models;

public class TaskDataModel
{
    public int Id { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public NoteDataModel Note { get; set; }
    public int NoteId { get; set; }
}