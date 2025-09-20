namespace LIN.Types.Communication.Models;

public class DeviceModel
{
    public int Id { get; set; }
    public string DeviceIdentifier { get; set; }
    public string DeviceName { get; set; }

    public int MeetingMemberId { get; set; }
    public MeetingMemberModel MeetingMember { get; set; }

}