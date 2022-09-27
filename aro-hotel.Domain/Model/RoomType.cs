namespace aro_hotel.Domain.Model;

public class RoomType : Entity
{
    public string Type { get; set; }
    public virtual ICollection<Room> Rooms { get; set; }
}
