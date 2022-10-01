namespace aro_hotel.Domain.Model;

public class RoomMultimediaXREF : Entity
{
    public int RoomId { get; set; }
    public int MultimediaId { get; set; }

    public virtual Room Room { get; set; }
    public virtual Multimedia Multimedia { get; set; }
}
