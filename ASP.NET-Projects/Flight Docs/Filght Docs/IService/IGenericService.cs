using Filght_Docs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Filght_Docs.IService
{
    public interface IGenericService
    {
        AircraftResponseDTO CalculateNextDue(int aircraftId, List<TaskInputDTO> tasks);
    }
}
