namespace assignment1.Models
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public decimal Price { get; set; }
        // Add other necessary properties
    }

    public class Hotel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public decimal Rating { get; set; }
        public decimal PricePerNight { get; set; }
        // Add other necessary properties
    }

    public class CarRental
    {
        public int RentalId { get; set; }
        public string Model { get; set; }
        public string Location { get; set; }
        public decimal PricePerDay { get; set; }
        // Add other necessary properties
    }

}
