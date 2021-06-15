using Filght_Docs.IService;
using Filght_Docs.Models;
using Filght_Docs.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filght_Docs.Service
{
    public class NextDueService : IGenericService
    {
        private AircraftRepository aircraftRepository = new AircraftRepository();

        public AircraftResponseDTO CalculateNextDue(int aircraftId, List<TaskInputDTO> tasks)
        {

            var aircraft = aircraftRepository.Get(aircraftId);
            foreach (var task in tasks)
            {
                if ( task.LogDate == null || task.IntervalMonths == null)
                    {
                        return null;
                    }
                var IntervalMonthsNextDueDate =  task.LogDate.AddMonths(task.IntervalMonths ?? 0);

                var DaysRemaingByHourInterval = ((task.LogHours + task.IntervalHours) - aircraft.CurrentHours) / aircraft.DailyHours;

                if (DaysRemaingByHourInterval == null)
                {
                    return null;
                }
               
            }
            return AircraftResponseDTO;
        }
    }
}
