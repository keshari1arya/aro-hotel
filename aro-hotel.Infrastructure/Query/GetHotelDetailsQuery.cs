using aro_hotel.Infrastructure.DTO.Response;
using MediatR;

namespace aro_hotel.Infrastructure.Query
{
    public class GetHotelDetailsQuery : IRequest<HotelResponse>
    {
        public readonly int Id;

        public GetHotelDetailsQuery(int id)
        {
            Id = id;
        }
    }
}

