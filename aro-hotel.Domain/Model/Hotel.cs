﻿namespace aro_hotel.Domain.Model;
public class Hotel : Entity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
}
