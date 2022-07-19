using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;
using Reservation.API.Models;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ResController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }
        [HttpGet("{Id}")]
        public ReservationDto Get(int Id)
        {
            return _reservationService.GetResByBkgNumber(Id);
        }
        [HttpGet]
        public ReservationDto GetAll()
        {
            return  _reservationService.GetResAll();
        }
    }
}
