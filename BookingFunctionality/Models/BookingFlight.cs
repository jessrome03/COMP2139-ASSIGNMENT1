using System;
using System.ComponentModel.DataAnnotations;

namespace BookingFunctionality.Models
{
    public class BookingFlight
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Origin is required.")]
        public string Origin { get; set; }

        [Required(ErrorMessage = "Destination is required.")]
        public string Destination { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DepartureTime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ArrivalTime { get; set; }

        public decimal Price { get; set; }
    }
}
