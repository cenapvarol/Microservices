using Reservation.API.Models;

namespace Reservation.API.Infrastructure
{
    public interface IReservationService
    {
        public ReservationDto GetResByBkgNumber(int bkgNumber);
        public ReservationDto GetResAll();
    }
}
