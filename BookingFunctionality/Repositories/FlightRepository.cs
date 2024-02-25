
using BookingFunctionality.Models;


namespace BookingFunctionality.Repositories

{
    public class FlightRepository
    {
        private readonly List<Flight> _flights;

        public FlightRepository()
        {
            _flights = new List<Flight>();
            SeedFlights(); 
        }

        public IEnumerable<Flight> GetAllFlights()
        {
            return _flights;
        }

        public Flight GetFlightById(int flightId)
        {
            return _flights.FirstOrDefault(f => f.Id == flightId);
        }


        private void SeedFlights()
        {
            _flights.Add(new Flight { Id = 1, Origin = "New York", Destination = "Los Angeles", DepartureTime = DateTime.Now, ArrivalTime = DateTime.Now.AddHours(6), Price = 300 });
            _flights.Add(new Flight { Id = 2, Origin = "Los Angeles", Destination = "Chicago", DepartureTime = DateTime.Now, ArrivalTime = DateTime.Now.AddHours(4), Price = 250 });
            _flights.Add(new Flight { Id = 3, Origin = "Chicago", Destination = "Miami", DepartureTime = DateTime.Now, ArrivalTime = DateTime.Now.AddHours(5), Price = 350 });
        }
    }
}
