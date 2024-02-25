
using System.ComponentModel.DataAnnotations;


namespace BookingFunctionality.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal Price { get; set; }
        public string FlightName { get; set; }

    }
}
