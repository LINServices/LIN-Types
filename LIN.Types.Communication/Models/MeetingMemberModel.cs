namespace LIN.Types.Communication.Models;

public class MeetingMemberModel
{ 
    public int Id { get; set; }
    public int MeetingId { get; set; }
    public List<DeviceModel> Devices { get; set; } = [];
    public MeetingModel Meeting { get; set; }
    public int ProfileId { get; set; }
    public ProfileModel ProfileModel { get; set; }

}