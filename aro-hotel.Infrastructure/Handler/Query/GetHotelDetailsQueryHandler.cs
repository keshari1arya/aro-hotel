using aro_hotel.Domain.Model;
using aro_hotel.Infrastructure.DTO.Response;
using aro_hotel.Infrastructure.Query;
using aro_hotel.Infrastructure.Repository;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace aro_hotel.Infrastructure.Handler.Query
{
    public class GetHotelDetailsQueryHandler : IRequestHandler<GetHotelDetailsQuery, HotelResponse>
    {
        private readonly IRepository<Hotel> repository;
        private readonly IMapper mapper;

        public GetHotelDetailsQueryHandler(IRepository<Hotel> repository, IMapper mapper)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public async Task<HotelResponse> Handle(GetHotelDetailsQuery request, CancellationToken cancellationToken)
        {
            var hotel = await this.repository.Entity()
                .Include(x => x.Address)
                .Include(x => x.Rooms)
                    .ThenInclude(x => x.Multimedias)
                .Include(x => x.Rooms)
                    .ThenInclude(x => x.RoomType)
                .Include(x => x.Rooms)
                    .ThenInclude(x => x.RoomFacilityXREFs)
                        .ThenInclude(x => x.Facility)
                .Include(x => x.Multimedias)
                .Include(x => x.HotelFacilityXREFs)
                    .ThenInclude(x => x.Facility)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == request.Id);
            return this.mapper.Map<HotelResponse>(hotel);
        }
    }
}

