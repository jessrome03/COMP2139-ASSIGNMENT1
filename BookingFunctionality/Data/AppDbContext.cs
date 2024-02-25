using Microsoft.EntityFrameworkCore;
using BookingFunctionality.Models;
using BookingFunctionality.Services.Models;

namespace BookingFunctionality.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
