
using System.ComponentModel.DataAnnotations;
namespace BookingFunctionality.Models
{
    public class FlightBookingViewModel
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string PassengerName { get; set; }
        public FlightBookingViewModel()
        {
            PassengerName = "";
        }

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string PassengerEmail { get; set; }

        [Required(ErrorMessage = "Please enter your phone number.")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        public string PassengerPhone { get; set; }

        [Required(ErrorMessage = "Please select a flight.")]
        public int SelectedFlightId { get; set; }

        [Required(ErrorMessage = "Please enter the number of passengers.")]
        [Range(1, int.MaxValue, ErrorMessage = "Number of passengers must be at least 1.")]
        public int NumPassengers { get; set; }

        [Required(ErrorMessage = "Please enter the departure date.")]
        [DataType(DataType.Date)]
        public DateTime DepartureDate { get; set; }

        public List<Flight> Flights { get; set; }

        public string FlightName { get; set; } 

        public int BookingId { get; set; }
        public string UserName { get; set; }
        public string ServiceType { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }


    }
}
