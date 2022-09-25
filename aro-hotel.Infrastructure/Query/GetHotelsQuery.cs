using System;
using aro_hotel.Infrastructure.DTO.Response;
using MediatR;

namespace aro_hotel.Infrastructure.Query
{
    public class GetHotelsQuery : IRequest<List<HotelResponse>>
    {

    }
}

