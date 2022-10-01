using aro_hotel.Infrastructure.DTO.Request;
using aro_hotel.Infrastructure.DTO.Response;
using MediatR;

namespace aro_hotel.Infrastructure.Command
{
    public class CreateMultimdediaCommand : IRequest<MultimediaResponse>
    {
        public readonly MultimediaRequest request;

        public CreateMultimdediaCommand(MultimediaRequest request)
        {
            this.request = request;
        }
    }
}

