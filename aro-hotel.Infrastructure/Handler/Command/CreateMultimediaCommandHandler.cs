using aro_hotel.Domain.Model;
using aro_hotel.Infrastructure.DTO.Response;
using aro_hotel.Infrastructure.Repository;
using aro_hotel.Infrastructure.Command;
using AutoMapper;
using MediatR;

namespace aro_hotel.Infrastructure.Handler.Command
{
    public class CreateMultimediaCommandHandler : IRequestHandler<CreateMultimdediaCommand, MultimediaResponse>
    {
        private readonly IRepository<HotelMultimediaXREF> hotelRepository;
        private readonly IRepository<RoomMultimediaXREF> roomRepository;
        private readonly IMapper mapper;

        public CreateMultimediaCommandHandler(IRepository<HotelMultimediaXREF> hotelRepository,
            IRepository<RoomMultimediaXREF> roomRepository,
        IMapper mapper)
        {
            this.mapper = mapper;
            this.hotelRepository = hotelRepository;
            this.roomRepository = roomRepository;
        }

        async Task<MultimediaResponse> IRequestHandler<CreateMultimdediaCommand, MultimediaResponse>.Handle(CreateMultimdediaCommand command, CancellationToken cancellationToken)
        {
            // TODO: This is a weird code need to be segregated for hotel and room

            var multimediaList = new List<Multimedia>();

            if (command.request.HotelId > 0)
            {
                foreach (var url in command.request.Urls)
                {
                    await this.hotelRepository.AddAsync(new HotelMultimediaXREF
                    {
                        HotelId = command.request.HotelId,
                        Multimedia = new Multimedia
                        {
                            Url = url,
                            Type = 1,
                        }
                    });
                }
                await this.hotelRepository.SaveChangesAsync();
            }

            if (command.request.RoomId > 0)
            {
                foreach (var url in command.request.Urls)
                {
                    await this.roomRepository.AddAsync(new RoomMultimediaXREF
                    {
                        RoomId = command.request.RoomId,
                        Multimedia = new Multimedia
                        {
                            Url = url,
                            Type = 1,
                        }
                    });
                }
                await this.roomRepository.SaveChangesAsync();
            }

            return this.mapper.Map<MultimediaResponse>(new MultimediaResponse());
        }
    }
}


