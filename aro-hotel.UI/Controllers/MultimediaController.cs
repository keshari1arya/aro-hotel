using System;
using aro_hotel.Infrastructure.Command;
using aro_hotel.Infrastructure.DTO.Request;
using aro_hotel.Infrastructure.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using static System.Net.Mime.MediaTypeNames;

namespace aro_hotel.UI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MultimediaController : ControllerBase
    {

        private readonly IMediator _mediatR;

        public MultimediaController(IMediator mediator)
        {
            this._mediatR = mediator;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload([FromForm] List<IFormFile> files, [FromForm] int? hotelId, [FromForm] int? roomId)
        {
            var request = new MultimediaRequest
            {
                HotelId = hotelId ?? 0,
                RoomId = roomId ?? 0,
                Urls = new List<string>()
            };

            // TODO: Sensitive data need to be placed in secure cloud. for now move it to appsettings.json
            Account account = new Account("dermmkmfo", "277129133887545", "ORITzvIkvhM0Jy6o5LQVAV4pDGU");
            Cloudinary cloudinary = new Cloudinary(account);
            cloudinary.Api.Secure = true;

            // TODO: Below code need to be changed to upload multi in a single API call

            foreach (var file in this.Request.Form.Files)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await file.CopyToAsync(memoryStream);
                    memoryStream.Position = 0;
                    var fileDescription = new FileDescription(file.FileName, memoryStream);
                    var uploadParams = new ImageUploadParams()
                    {
                        File = fileDescription,
                    };
                    var uploadResult = await cloudinary.UploadAsync(uploadParams);
                    request.Urls.Add(uploadResult.Url.ToString());
                }
            }


            CreateMultimdediaCommand query = new(request);
            return Ok(await this._mediatR.Send(query));
        }
    }
}

