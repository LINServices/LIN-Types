namespace LIN.Types.Cloud.Edge.Enums;

/// <summary>
/// Motor de base de datos administrado sobre el que se ejecuta una operación de backup o restauración.
/// </summary>
public enum DatabaseEngine
{
    /// <summary>
    /// PostgreSQL. Valor por defecto: los registros creados antes de soportar varios motores son de Postgres.
    /// </summary>
    Postgres = 0,

    /// <summary>
    /// MySQL / MariaDB.
    /// </summary>
    MySql = 1,

    /// <summary>
    /// MongoDB.
    /// </summary>
    Mongo = 2
}
