namespace LIN.Types.Developer;

/// <summary>
/// Constantes de permisos de la plataforma RBAC.
/// Los valores corresponden a los permisos sembrados en rbac-permissions.json
/// </summary>
public static class PermissionConstants
{
    /// <summary>
    /// Permisos relacionados con recursos (proyectos).
    /// </summary>
    public static class Resource
    {
        public const string Read = "resource:read";
        public const string Delete = "resource:delete";
        public const string Rename = "resource:rename";
        public const string AssociateGroup = "resource:asociategroup";
        public const string AssociateResource = "resource:asociateresource";
    }

    /// <summary>
    /// Pemrisos relacionados con tickets y recursos.
    /// </summary>
    public static class Ticket
    {
        public const string Create = "resource:tickets:create";
        public const string Post = "resource:tickets:post";
        public const string Read = "resource:tickets:read";
        public const string Close = "resource:tickets:close";
    }

    /// <summary>
    /// Pemrisos relacionados con pagos y recursos.
    /// </summary>
    public static class Payment
    {
        public const string Read = "resource:payments:read";
    }

    /// <summary>
    /// Permisos relacionados con claves API.
    /// </summary>
    public static class Keys
    {
        public const string Create = "keys:create";
        public const string View = "keys:view";
        public const string ViewSecret = "keys:viewsecret";
        public const string State = "keys:state";
        public const string Delete = "keys:delete";
    }

    /// <summary>
    /// Permisos relacionados con reglas de firewall.
    /// </summary>
    public static class Firewall
    {
        public const string Create = "firewall:create";
        public const string View = "firewall:view";
        public const string Delete = "firewall:delete";
    }

    /// <summary>
    /// Permisos relacionados con la comunidad.
    /// </summary>
    public static class Community
    {
        public const string Share = "community:share";
        public const string ShareRemove = "community:shareremove";
        public const string ShareRead = "community:shareread";
        public const string RoleAssigning = "community:roleasing";
    }

    /// <summary>
    /// Permisos relacionados con sites (.NET, Node.js, etc.).
    /// </summary>
    public static class Site
    {
        public const string Swap = "site:swap";
        public const string GitHandle = "site:githandle";
        public const string AutoSwap = "site:autoswap";
        public const string HttpHandle = "site:httphandle";
        public const string LaunchRelease = "site:launchrelease";
        public const string AddDomain = "site:adddomain";
        public const string AutoScaleConfiguration = "site:autoscaleconfiguration";
        public const string StopSite = "site:stopsite";
        public const string StartSite = "site:startsite";
    }

    /// <summary>
    /// Permisos relacionados con planes de suscripción.
    /// </summary>
    public static class Plan
    {
        public const string ConfigurationUpdate = "plan:configurationupdate";
        public const string MigrateRegion = "plan:migrateregion";
        public const string View = "plan:view";
    }
}