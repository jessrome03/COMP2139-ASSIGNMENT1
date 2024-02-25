using Microsoft.AspNetCore.Mvc;

using BookingFunctionality.Services;
using BookingFunctionality.Models;

using BookingFunctionality.Repositories; 

namespace BookingFunctunality.Controllers
{
    public class BookingController : Controller
    {
        private readonly BookingServices _bookingService;
        private readonly BookingRepository _bookingRepository;
        private readonly FlightRepository _flightRepository;

        public BookingController(BookingServices bookingService, BookingRepository bookingRepository, FlightRepository flightRepository)
        {
            _bookingService = bookingService;
            _bookingRepository = bookingRepository;
            _flightRepository = flightRepository;
        }

        public IActionResult BookFlight()
        {
            var flights = _flightRepository.GetAllFlights();
            return View(flights);
        }

        [HttpPost]
        public IActionResult ConfirmFlight(FlightBookingViewModel model)
        {
            if (ModelState.IsValid)
            {
                var bookingResult = _bookingService.BookFlight(model);
                if (bookingResult.IsSuccess)
                {
                    return RedirectToAction("Confirmation", new { bookingId = bookingResult.BookingId });
                }
                else
                {
                    ModelState.AddModelError(string.Empty, bookingResult.ErrorMessage);
                }
            }
            return View("BookFlight", model);
        }

        public IActionResult Confirmation(int bookingId)
        {
            var booking = _bookingRepository.GetBookingById(bookingId);
            return View(booking);
        }
    }
}
