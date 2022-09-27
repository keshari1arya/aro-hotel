namespace aro_hotel.Domain.Model;

public class RoomFacilityXREF : Entity
{
    public int RoomId { get; set; }
    public int FacilityId { get; set; }

    public virtual Room Room { get; set; }
    public virtual Facility Facility { get; set; }
}
