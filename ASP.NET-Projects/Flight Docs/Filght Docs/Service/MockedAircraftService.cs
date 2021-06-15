using Filght_Docs.IService;
using Filght_Docs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filght_Docs.Service
{
    public class MockedAircraftService : IGenericService<MockedAircraft>
    {
        private static Models.TaskInputDTO airplane1 = new Models.TaskInputDTO();
        private static MockedAircraft mockedAircraft = new MockedAircraft();
        List<MockedAircraft> _mockedAircraft = new List<MockedAircraft>();
        
        public List<MockedAircraft> Delete(int id)
        {
            _mockedAircraft.RemoveAll(x => x.AircratId == id);
            return _mockedAircraft;
        }

        public List<MockedAircraft> GetAll()
        {
            return _mockedAircraft;
        }

        public  List<MockedAircraft> GetById(int id)
        {
            _mockedAircraft.Where(x => x.AircratId == id).SingleOrDefault();
            return _mockedAircraft;
        }

        public List<MockedAircraft> Insert(MockedAircraft item)
        {
            DateTime _logDate = airplane1.LogDate;
            //int IntervalMonthsNextDueDate;
            //IntervalMonthsNextDueDate = airplane1.IntervalMonths + _logDate ?? default(int);
            float DaysRemainingByHoursInterval;
            DaysRemainingByHoursInterval = ((airplane1.LogHours + airplane1.IntervalHours) - mockedAircraft.CurrentHours) / mockedAircraft.DailyHours ?? default(float);
            // int IntervalHoursNextDueDate;
           // string date = "";
           // IntervalHoursNextDueDate = DaysRemainingByHoursInterval + date;
            // int NextDueDate;
           // NextDueDate = MIN(IntervalMonthsNextDueDate, Interval)

            throw new NotImplementedException();
        }
    }
}
