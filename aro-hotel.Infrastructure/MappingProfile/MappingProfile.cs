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
            CreateMap<Hotel, HotelResponse>();
            CreateMap<HotelRequest, Hotel>()
                .ForMember(de => de.Id, con => con.MapFrom(src => src.Id ?? 0))
                .ForMember(de => de.UpdatedAt, con => con.Ignore())
                .ForMember(de => de.UpdatedBy, con => con.Ignore())
                .ForMember(de => de.CreatedBy, con => con.Ignore())
                .ForMember(de => de.CreatedAt, con => con.Ignore());
        }

    }
}