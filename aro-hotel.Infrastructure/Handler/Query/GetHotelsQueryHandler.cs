using System;
using aro_hotel.Domain.Model;
using aro_hotel.Infrastructure.DTO.Response;
using aro_hotel.Infrastructure.Query;
using aro_hotel.Infrastructure.Repository;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace aro_hotel.Infrastructure.Handler.Query
{
    public class GetHotelsQueryHandler : IRequestHandler<GetHotelsQuery, List<HotelResponse>>
    {
        private readonly IRepository<Hotel> repository;
        private readonly IMapper mapper;

        public GetHotelsQueryHandler(IRepository<Hotel> repository, IMapper mapper)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public async Task<List<HotelResponse>> Handle(GetHotelsQuery request, CancellationToken cancellationToken)
        {
            var hotels = await this.repository.Entity().Include(x => x.Address)
                .Include(x => x.HotelMultimediaXREFs)
                .ThenInclude(x => x.Multimedia).AsNoTracking().ToListAsync();
            return this.mapper.Map<List<HotelResponse>>(hotels);
        }
    }
}

