namespace LIN.Types.Identity.Models;


public class DirectoryMember
{

    public DirectoryModel Directory { get; set; }
    public AccountModel Account { get; set; }

    public int AccountId { get; set; }
    public int DirectoryId { get; set; }


}
