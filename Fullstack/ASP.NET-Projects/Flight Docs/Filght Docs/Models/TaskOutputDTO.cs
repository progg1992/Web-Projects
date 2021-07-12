using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filght_Docs.Models
{
    public class TaskOutputDTO
    {
        public int ItemNumber { get; set; }
        public string Description { get; set; }
        public DateTime LogDate { get; set; }
        public int? LogHours { get; set; }
        public int? IntervalMonths { get; set; }
        public int? IntervalHours { get; set; }
        public DateTime NextDueDate { get; set; }
    }
}
