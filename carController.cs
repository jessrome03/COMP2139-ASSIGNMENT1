using System;
using Microsoft.AspNetCore.Mvc;

public class HotelController : Controller
{
    // Action method to display hotel details
    public IActionResult Details(int id)
    {
        // Fetch hotel details from database or other data source based on the provided id
        var hotel = GetHotelDetailsFromDatabase(id);

        if (hotel == null)
        {
            // Return a 404 Not Found response if hotel is not found
            return NotFound();
        }

        // Pass hotel details to the view
        return View(hotel);
    }

    // Action method to handle booking a room in the hotel
    [HttpPost]
    public IActionResult BookRoom(int roomId, string guestName, DateTime checkInDate, DateTime checkOutDate)
    {
        // Logic to book a room based on provided parameters
        // This could involve database operations to save booking details, etc.

        // For demonstration purposes, let's just return a success message
        return Content($"Room {roomId} booked for {guestName} from {checkInDate.ToShortDateString()} to {checkOutDate.ToShortDateString()}.");
    }

    // Sample method to fetch hotel details from a database (dummy implementation)
    private HotelModel GetHotelDetailsFromDatabase(int id)
    {
        // Dummy implementation - replace this with actual database logic
        return new HotelModel
        {
            Id = id,
            Name = "Sample Hotel",
            Location = "Sample Location",
            Description = "A sample hotel description."
        };
    }

    // Sample model representing hotel details (replace with actual model)
    private class HotelModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}
