using System;
using aro_hotel.Domain.Model;
using aro_hotel.Infrastructure;
using aro_hotel.Infrastructure.DTO.Request;
using aro_hotel.Infrastructure.Query;
using aro_hotel.Infrastructure.Repository;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace aro_hotel.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelController : ControllerBase
    {
        public IRepository<Hotel> drugRepository { get; }

        private readonly IMediator _mediatR;

        public HotelController(IMediator mediator)
        {
            this._mediatR = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var query = new GetHotelsQuery();
            return Ok(await this._mediatR.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await this.drugRepository.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(HotelRequest request)
        {
            var command = new CreateHotelCommand(request);
            await this._mediatR.Send(command);
            return Created("/{id}", request);
        }
    }
}

