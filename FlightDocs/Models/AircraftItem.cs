using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightDocs.Models
{
    public class AircraftItem
    {
        public int Id { get; set; }
        public int ItemNumber { get; set; }
        public string Description { get; set; }
        public DateTime LogDate { get; set; }
        public int? LogHours { get; set; } // Need to Figure out how to set so if can be null
        public int? IntervalMonths { get; set; } // Need to Figure out how to set so if can be null
        public int? IntervalHours { get; set; } // Need to Figure out how to set so if can be null
    }
}
