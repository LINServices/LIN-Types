namespace LIN.Cloud.Synapse.Types.Enums;

[Flags]
public enum ModelCapability
{
    None = 0,
    Chat = 1,
    Completion = 2,
    Embedding = 4
}
