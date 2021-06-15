using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filght_Docs.Models;

namespace Filght_Docs.Repositories
{
    public class AircraftRepository : IRepository<MockedAircraft>

    {
        List<MockedAircraft> _mockedAircraft = new List<MockedAircraft>();

        public AircraftRepository()
        {
            _mockedAircraft.Add(new MockedAircraft()
            {
                AircratId = 1,
                DailyHours = 0.7f,
                CurrentHours = 550
            });

            _mockedAircraft.Add(new MockedAircraft()
            {
                AircratId = 2,
                DailyHours = 0.7f,
                CurrentHours = 200,
            });
        }

        public MockedAircraft Get(int id)
        {
            var result = _mockedAircraft.Where(x => x.AircratId == id).SingleOrDefault();
            return result;
        }
    }
}
             