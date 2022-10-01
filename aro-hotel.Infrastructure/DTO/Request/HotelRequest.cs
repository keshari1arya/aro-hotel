using System;
namespace aro_hotel.Infrastructure.DTO.Request
{
    public class HotelRequest
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public AddressRequest Address { get; set; }
    }

    public class MultimediaRequest
    {
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public List<string> Urls { get; set; }
    }
}

