namespace aro_hotel.Domain.Model;
public class Hotel : Entity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Phone { get; set; }

    public ICollection<Multimedia> Multimedias { get; set; }
    public ICollection<Room> Rooms { get; set; }
    public Address Address { get; set; }

    public virtual ICollection<HotelFacilityXREF> HotelFacilityXREFs { get; set; }
}
