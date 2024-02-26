using Microsoft.AspNetCore.Mvc;

namespace assignment1.Controllers
{
    public class HotelController : Controller
    {
        // Implement action methods to handle hotel-related requests

        // For example, a method to display a list of hotels
        public IActionResult Index()
        {
            // Fetch hotels from the database or any other data source
            var hotels = GetHotelsFromDatabase();

            // Pass the hotels data to the view
            return View(hotels);
        }

        // Method to retrieve hotels from the database (dummy implementation for demonstration)
        private List<Hotel> GetHotelsFromDatabase()
        {
            // Dummy implementation to simulate fetching hotels from a database
            var hotels = new List<Hotel>
        {
            new Hotel { Id = 1, Name = "Hotel A", Address = "123 Main St" },
            new Hotel { Id = 2, Name = "Hotel B", Address = "456 Elm St" },
            new Hotel { Id = 3, Name = "Hotel C", Address = "789 Oak St" }
        };
            return hotels;
        }
    }

    // Define a simple Hotel class for demonstration
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}