﻿namespace LIN.Types.Cloud.Edge.RequestModels;

public class PostgresRequestModel
{
    public string Name { get; set; }
    public string DatabaseName { get; set; }
    public string DefaultUser { get; set; }
    public string Password { get; set; }
}
