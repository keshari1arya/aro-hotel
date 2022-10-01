using System;
using aro_hotel.Infrastructure.DTO.Request;
using aro_hotel.Infrastructure.DTO.Response;
using MediatR;

namespace aro_hotel.Infrastructure.Command
{
    public class CreateHotelCommand : IRequest<HotelResponse>
    {
        public readonly HotelRequest request;

        public CreateHotelCommand(HotelRequest request)
        {
            this.request = request;
        }
    }
}

