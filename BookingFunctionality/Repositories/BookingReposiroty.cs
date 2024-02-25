using BookingFunctionality.Models;
using BookingFunctionality.Services.Models;

namespace BookingFunctionality.Repositories
{
    public class BookingRepository
    {
        private readonly List<Booking> _bookings;

        public BookingRepository()
        {
            _bookings = new List<Booking>();
        }

        public void AddBooking(Booking booking)
        {
            _bookings.Add(booking);
        }

        public Booking GetBookingById(int bookingId)
        {
            return _bookings.FirstOrDefault(b => b.Id == bookingId);
        }

        internal int BookingFlight(FlightBookingViewModel model)
        {
            throw new NotImplementedException();
        }



        
    }
}
