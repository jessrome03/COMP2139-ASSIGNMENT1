
using BookingFunctionality.Repositories;
using BookingFunctionality.Models;





namespace BookingFunctionality.Services
{
    public class BookingServices
    {
        private readonly BookingRepository _bookingRepository;

        public BookingServices(BookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public BookingResult BookFlight(FlightBookingViewModel model)
        {
            if (model == null)
            {
                return new BookingResult { IsSuccess = false, ErrorMessage = "Invalid booking request" };
            }


            try
            {
                var bookingId = _bookingRepository.BookingFlight(model);

                return new BookingResult { IsSuccess = true, BookingId = bookingId };
            }
            catch (Exception ex)
            {
                return new BookingResult { IsSuccess = false, ErrorMessage = $"Booking failed: {ex.Message}" };
            }
        }
    }
}
