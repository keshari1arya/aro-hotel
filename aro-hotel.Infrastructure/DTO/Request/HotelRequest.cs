﻿using System;
namespace aro_hotel.Infrastructure.DTO.Request
{
    public class HotelRequest
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}

