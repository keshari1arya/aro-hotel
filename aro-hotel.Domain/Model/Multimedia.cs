namespace aro_hotel.Domain.Model;

public class Multimedia : Entity
{
    public string Url { get; set; }
    public int Type { get; set; }

    public virtual ICollection<HotelMultimediaXREF> HotelMultimediaXREFs { get; set; }
    public virtual ICollection<RoomMultimediaXREF> RoomMultimediaXREFs { get; set; }
}
