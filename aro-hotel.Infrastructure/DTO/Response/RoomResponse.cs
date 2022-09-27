namespace aro_hotel.Infrastructure.DTO.Response
{
    public class RoomResponse
    {
        public string RoomType { get; set; }
        public int Occupancy { get; set; }
        public List<MultimediaResponse> Multimedias { get; set; }
    }
}

