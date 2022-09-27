namespace aro_hotel.Domain.Model;

public class HotelFacilityXREF : Entity
{
    public int HotelId { get; set; }
    public int FacilityId { get; set; }

    public virtual Hotel Hotel { get; set; }
    public virtual Facility Facility { get; set; }
}
