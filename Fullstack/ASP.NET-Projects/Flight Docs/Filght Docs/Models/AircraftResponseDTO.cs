using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filght_Docs.Models
{
    public class AircraftResponseDTO
    {
        public int AircraftId { get; set; }
        public List<TaskOutputDTO> Tasks { get; set; }
    }
}
