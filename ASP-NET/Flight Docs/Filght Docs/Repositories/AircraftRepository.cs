using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Filght_Docs.Models;

namespace Filght_Docs.Repositories
{
    public class AircraftRepository<T> : IRepository<T> where T : class
   
    {
        //private MockedAircraft aircraft1 = new MockedAircraft();
        //private MockedAircraft aircraft2 = new MockedAircraft();
        private ArrayList aircraftData = new ArrayList();
        
        private MockedAircraftRepository()
        {
            //aircraft1.AircratId = 1;
            //aircraft1.DailyHours = 0.7f;
            //aircraft1.CurrentHours = 550;

            //aircraft2.AircratId = 2;
            //aircraft2.DailyHours = 1.1f;
            //aircraft2.CurrentHours = 200;

            //var mockedAircraft = new ArrayList();
            //mockedAircraft.Add(aircraft1);
            //mockedAircraft.Add(aircraft2);
        }

        private ArrayList Aircraft = new ArrayList();

        public T Get(Guid id)
        {
         
        }
    }
                }
             