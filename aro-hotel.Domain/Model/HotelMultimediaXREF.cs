namespace aro_hotel.Domain.Model;

public class HotelMultimediaXREF : Entity
{
    public int HotelId { get; set; }
    public int MultimediaId { get; set; }

    public virtual Hotel Hotel { get; set; }
    public virtual Multimedia Multimedia { get; set; }
}
