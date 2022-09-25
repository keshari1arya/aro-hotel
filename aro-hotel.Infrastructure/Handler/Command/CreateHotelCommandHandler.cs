using System;
using aro_hotel.Domain.Model;
using aro_hotel.Infrastructure.DTO.Response;
using aro_hotel.Infrastructure.Repository;
using AutoMapper;
using MediatR;

namespace aro_hotel.Infrastructure.Handler.Command
{
    public class CreateHotelCommandHandler : IRequestHandler<CreateHotelCommand, HotelResponse>
    {
        private readonly IRepository<Hotel> repository;
        private readonly IMapper mapper;

        public CreateHotelCommandHandler(IRepository<Hotel> repository, IMapper mapper)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        async Task<HotelResponse> IRequestHandler<CreateHotelCommand, HotelResponse>.Handle(CreateHotelCommand command, CancellationToken cancellationToken)
        {
            var hotel = this.mapper.Map<Hotel>(command.request);
            await this.repository.Add(hotel);
            await this.repository.SaveChangesAsync();

            return this.mapper.Map<HotelResponse>(hotel);
        }
    }
}


