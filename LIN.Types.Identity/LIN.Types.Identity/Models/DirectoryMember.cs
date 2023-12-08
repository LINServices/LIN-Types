namespace LIN.Types.Identity.Models;


public class DirectoryMember
{

    public DirectoryModel Directory { get; set; } = null!;
    public AccountModel Account { get; set; } = null!;

    public int AccountId { get; set; }
    public int DirectoryId { get; set; }


}
