using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIN.Types.Cloud.Models;

public class Folder
{

    public string Name { get; set; }
    public List<Folder> Folders { get; set; } = new();

    public List<Files> Files { get; set; } = new();


}
