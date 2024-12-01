using System;
using System.Collections.Generic;
using System.Text;

namespace LIN.Types.Cloud.Mongo.Models;

public class CreateDatabaseRequest
{
    public string DatabaseName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}
