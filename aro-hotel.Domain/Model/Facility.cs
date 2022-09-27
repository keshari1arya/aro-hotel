namespace aro_hotel.Domain.Model;

public class Facility : Entity
{
    public string Name { get; set; }

    public virtual ICollection<HotelFacilityXREF> HotelFacilityXREFs { get; set; }
    public virtual ICollection<RoomFacilityXREF> RoomFacilityXREFs { get; set; }
}
