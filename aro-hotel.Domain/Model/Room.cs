namespace aro_hotel.Domain.Model;

public class Room : Entity
{
    public int RoomTypeId { get; set; }
    public int Occupancy { get; set; }
    public int Price { get; set; }

    public virtual Hotel Hotel { get; set; }
    public virtual int HotelId { get; internal set; }
    public virtual ICollection<RoomFacilityXREF> RoomFacilityXREFs { get; set; }

    public virtual ICollection<RoomMultimediaXREF> RoomMultimediaXREFs { get; set; }
    public virtual RoomType RoomType { get; set; }
}
