using System;
using aro_hotel.Domain.Model;
using aro_hotel.Infrastructure.DTO.Request;
using aro_hotel.Infrastructure.DTO.Response;
using AutoMapper;

namespace aro_hotel.Infrastructure.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Hotel, HotelResponse>()
                .ForMember(x => x.Facilities, con => con.MapFrom(x => x.HotelFacilityXREFs.Select(x => x.Facility.Name).ToList()));
            CreateMap<Address, AddressResponse>();
            CreateMap<Multimedia, MultimediaResponse>();
            CreateMap<Room, RoomResponse>()
                .ForMember(de => de.RoomType, con => con.MapFrom(src => src.RoomType.Type))
                .ForMember(x => x.Facilities, con => con.MapFrom(x => x.RoomFacilityXREFs.Select(x => x.Facility.Name).ToList()));


            CreateMap<HotelRequest, Hotel>()
                .ForMember(de => de.Id, con => con.MapFrom(src => src.Id ?? 0))
                .ForMember(de => de.Address, con => con.MapFrom(src => new Address
                {
                    City = src.City,
                    Country = src.Country,
                    Id = src.Id ?? 0,
                    LandMark = src.LandMark,
                    Line1 = src.Line1,
                    Line2 = src.Line2,
                    State = src.State,
                    Pincode = src.Pincode
                }));

        }

    }
}