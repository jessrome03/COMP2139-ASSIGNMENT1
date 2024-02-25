using System;
using System.ComponentModel.DataAnnotations;

namespace BookingFunctionality.Services.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        public DateTime BookingDate { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
