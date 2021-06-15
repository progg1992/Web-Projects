using Filght_Docs.IService;
using Filght_Docs.Models;
using Filght_Docs.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Filght_Docs.Controllers
{
    
    [ApiController]
    public class AircraftController : ControllerBase
    {
        private AircraftRepository aircraftRepository = new AircraftRepository();
        
        // POST <AirplaneController>
        [HttpPost("aircraft/{aircraftId}/duelist")]
        public AircraftResponseDTO Post(int aircraftId, [FromBody] List<TaskInputDTO> tasks)
        {
            var aircraft = aircraftRepository.Get(aircraftId);

            
            
            return new AircraftResponseDTO() { AircraftId = aircraftId};
        }
    }
}
