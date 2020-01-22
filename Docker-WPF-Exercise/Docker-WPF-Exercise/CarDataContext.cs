using Docker_WPF_Exercise.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Docker_WPF_Exercise
{
    public class CarDataContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public CarDataContext(DbContextOptions<CarDataContext> options) : base(options)
        { }
    }
}
