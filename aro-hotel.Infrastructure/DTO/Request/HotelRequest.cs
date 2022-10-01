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

    public class AddressRequest
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Pincode { get; set; }
        public string LandMark { get; set; }
    }
}

