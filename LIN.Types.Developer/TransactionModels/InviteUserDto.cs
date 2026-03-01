namespace LIN.Types.Developer.TransactionModels;

public class InviteUserDto
{
    public int ProfileId { get; set; }
    public int ResourceId { get; set; }
    public FinancePermission FinancePermission { get; set; }
    public ResourcePermission ResourcePermission { get; set; }
}