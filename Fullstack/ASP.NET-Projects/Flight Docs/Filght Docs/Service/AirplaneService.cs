//using Filght_Docs.IService;
//using Filght_Docs.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Filght_Docs.Service
//{
//    public class AirplaneService : IGenericService<Models.TaskInputDTO>
//    {
//        private Models.TaskInputDTO airplane = new Models.TaskInputDTO { };
//        private Models.TaskInputDTO airplane2 = new Models.TaskInputDTO { };
//        List<Models.TaskInputDTO> _airplane = new List<Models.TaskInputDTO>();

//        public AirplaneService()
//        {
//            for (int i = 1; i <= 5; i++)
//            {
//                if (i == 1)
//                {
//                    _airplane.Add(new TaskInputDTO()
//                    {
//                        AircratId = i,
//                        ItemNumber = i,
//                        Description = "Item " + i,
//                        LogDate = "2018-04-07T00:00:00",
//                        LogHours = null,
//                        IntervalMonths = null,
//                        IntervalHours = null
//                    });

//                }
//                else if (i == 2)
//                {
//                    _airplane.Add(new Models.TaskInputDTO()
//                    {
//                        // AircratId = i,
//                        ItemNumber = 2,
//                        Description = "Item " + i,
//                        LogDate = "2018-04-07T00:00:00",
//                        LogHours = 100,
//                        IntervalMonths = 12,
//                        IntervalHours = 500
//                    });
//                }
//                else if (i == 3)
//                {
//                    _airplane.Add(new Models.TaskInputDTO()
//                    {
//                        //AircratId = 1,
//                        ItemNumber = 3,
//                        Description = "Item 3",
//                        LogDate = "2018-06-01T00:00:00",
//                        LogHours = 150,
//                        IntervalMonths = null,
//                        IntervalHours = 400
//                    });
//                }
//                else
//                {
//                    _airplane.Add(new Models.TaskInputDTO()
//                    {
//                        //AircratId = 2,
//                        ItemNumber = 4,
//                        Description = "Item 4",
//                        LogDate = "2018-06-01T00:00:00",
//                        LogHours = 150,
//                        IntervalMonths = 6,
//                        IntervalHours = null
//                    });
//                }
//            };

//        }

//        public List<Models.TaskInputDTO> Delete(int id)
//        {
//            _airplane.RemoveAll(x => x.AircratId == id);
//            return _airplane;
//        }

//        public List<Models.TaskInputDTO> GetAll()
//        {
//            return _airplane;
//        }

//        public List<Models.TaskInputDTO> GetById(int id)
//        {
//            _airplane.Where(x => x.AircratId == id).SingleOrDefault();
//            return _airplane;
//        }

//        public List<Models.TaskInputDTO> Insert(Models.TaskInputDTO item)
//        {

//            _airplane.Add(item);

//            return _airplane;
//        }


//    }
//}
