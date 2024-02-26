using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using YourNamespace.Models; // Import your Flight model

namespace YourNamespace.Controllers
{
    public class FlightController : Controller
    {
        // Assuming you have some DbContext or service to interact with the database
        private readonly YourDbContext _context;

        public FlightController(YourDbContext context)
        {
            _context = context;
        }

        // Action method to display a list of flights
        public IActionResult Index()
        {
            List<Flight> flights = _context.Flights.ToList();
            return View(flights);
        }

        // Action method to display details of a specific flight
        public IActionResult Details(int id)
        {
            Flight flight = _context.Flights.FirstOrDefault(f => f.FlightId == id);
            if (flight == null)
            {
                return NotFound(); // Return a 404 Not Found error if flight is not found
            }
            return View(flight);
        }

        // Action method to search for flights based on criteria
        [HttpPost]
        public IActionResult Search(string origin, string destination, DateTime departureDate)
        {
            // Perform the search query based on the provided criteria
            List<Flight> flights = _context.Flights
                .Where(f => f.Origin == origin && f.Destination == destination && f.DepartureDate.Date == departureDate.Date)
                .ToList();

            return View(flights);
        }

        // Other action methods for adding, editing, deleting flights, etc. can be implemented here
    }
}
