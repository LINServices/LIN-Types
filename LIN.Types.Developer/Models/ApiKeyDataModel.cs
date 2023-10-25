﻿namespace LIN.Types.Developer.Models;


public class ApiKeyDataModel
{


    public int ID { get; set; }


    [Column("NOMBRE")]
    public string Nombre { get; set; } = string.Empty;


    [Column("LLAVE")]
    public string Key { get; set; } = string.Empty;


    [Column("ESTADO")]
    public ApiKeyStatus Status { get; set; } = ApiKeyStatus.Actived;


    [Column("PROJECT_FK")]
    public ProjectDataModel Project { get; set; }


}