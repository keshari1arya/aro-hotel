namespace aro_hotel.Infrastructure.DTO.Response
{
    public class RoomResponse
    {
        public string RoomType { get; set; }
        public int Price { get; set; }
        public int Occupancy { get; set; }
        public List<MultimediaResponse> Multimedias { get; set; }
        public List<string> Facilities { get; internal set; }
    }
}

