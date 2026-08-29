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
        public const string Read = "object:resource:read";
        public const string Delete = "object:resource:delete";
        public const string Rename = "object:resource:rename";
        public const string AssociateGroup = "object:resource:asociategroup";
        public const string AssociateResource = "object:resource:asociateresource";
    }

    /// <summary>
    /// Pemrisos relacionados con tickets y recursos.
    /// </summary>
    public static class Ticket
    {
        public const string Create = "object:tickets:create";
        public const string Post = "object:tickets:post";
        public const string Read = "object:tickets:read";
        public const string Close = "object:tickets:close";
    }

    /// <summary>
    /// Pemrisos relacionados con pagos y recursos.
    /// </summary>
    public static class Payment
    {
        public const string Read = "object:payments:read";
    }

    /// <summary>
    /// Permisos relacionados con claves API.
    /// </summary>
    public static class Keys
    {
        public const string Create = "object:keys:create";
        public const string View = "object:keys:view";
        public const string ViewSecret = "object:keys:viewsecret";
        public const string State = "object:keys:state";
        public const string Delete = "object:keys:delete";
    }

    /// <summary>
    /// Permisos relacionados con reglas de firewall.
    /// </summary>
    public static class Firewall
    {
        public const string Create = "object:firewall:create";
        public const string View = "object:firewall:view";
        public const string Delete = "object:firewall:delete";
    }

    /// <summary>
    /// Permisos relacionados con la comunidad.
    /// </summary>
    public static class Community
    {
        public const string Share = "object:community:share";
        public const string ShareRemove = "object:community:shareremove";
        public const string ShareRead = "object:community:shareread";
        public const string RoleAssigning = "object:community:roleassigning";
    }

    /// <summary>
    /// Permisos relacionados con sites (.NET, Node.js, etc.).
    /// </summary>
    public static class Site
    {
        public const string Swap = "object:site:swap";
        public const string GitHandle = "object:site:githandle";
        public const string AutoSwap = "object:site:autoswap";
        public const string HttpHandle = "object:site:httphandle";
        public const string LaunchRelease = "object:site:launchrelease";
        public const string AddDomain = "object:site:adddomain";
        public const string AutoScaleConfiguration = "object:site:autoscaleconfiguration";
        public const string StopSite = "object:site:stopsite";
        public const string StartSite = "object:site:startsite";
    }

    /// <summary>
    /// Permisos relacionados con planes de suscripción.
    /// </summary>
    public static class Plan
    {
        public const string ConfigurationUpdate = "object:plan:configurationupdate";
        public const string MigrateRegion = "object:plan:migrateregion";
        public const string View = "object:plan:view";
    }
}