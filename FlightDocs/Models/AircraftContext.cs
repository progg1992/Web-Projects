using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FlightDocs.Models
{
    public class AircraftContext : DbContext
    {
        public AircraftContext(DbContextOptions<AircraftContext> options)
            : base(options)
        {
        }

        public DbSet<AircraftItem> AircraftItems { get; set; }
    }
}
