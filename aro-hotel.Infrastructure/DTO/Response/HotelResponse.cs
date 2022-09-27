using System;
using aro_hotel.Domain.Model;

namespace aro_hotel.Infrastructure.DTO.Response
{
    public class HotelResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public AddressResponse Address { get; set; }
        public string Phone { get; set; }
        public List<MultimediaResponse> Multimedias { get; set; }
        public List<RoomResponse> Rooms { get; set; }
        public List<string> Facilities { get; set; }
    }
}

