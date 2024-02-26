public class BookingController : Controller
{
    // Handle the GET request for booking
    public IActionResult Book()
    {
        return View();
    }

    // Handle the POST request for submitting a booking
    [HttpPost]
    public IActionResult Book(BookingViewModel model)
    {
        // Validate and process the booking details
        // Save booking details to the database or temporary storage
        // Redirect to a confirmation page
        return RedirectToAction("Confirmation", new { bookingId = model.BookingId });
    }

    // Confirmation page action
    public IActionResult Confirmation(int bookingId)
    {
        // Retrieve booking details from the database or temporary storage
        var bookingDetails = GetBookingDetails(bookingId);
        return View(bookingDetails);
    }
}
