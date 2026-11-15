namespace LIN.Cloud.Synapse.Types.Private;

/// <summary>Estado de un modelo para un tenant concreto.</summary>
public enum TenantModelStatus
{
    /// <summary>El modelo está disponible para el tenant.</summary>
    Available = 0,

    /// <summary>El modelo no está incluido en el plan del tenant.</summary>
    NotIncluded = 1,

    /// <summary>El modelo no está disponible globalmente.</summary>
    Unavailable = 2
}
