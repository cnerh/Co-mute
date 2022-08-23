using CoMute.Web.Models;
using CoMute.Web.Models.Dto;
using CoMute.Web.Models.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace CoMute.Web.Controllers.API
{
    public class CarController : ApiController
    {
        CoMuteDBContext _dbContext = new CoMuteDBContext();

        [Route("CarPool/add")]
        [HttpPost]
        public HttpResponseMessage Post([FromBody] CarPool carPool)
        {

            var CarPool = new CarPool()
            {
                CarPoolID = Guid.NewGuid().ToString(),
                DepartureTime = carPool.DepartureTime,
                ExpectedArrivaltime = carPool.ExpectedArrivaltime,
                Origin = carPool.Origin,
                DaysAvailable = carPool.DaysAvailable,
                Destination = carPool.Destination,
                AvailableSeats = carPool.AvailableSeats,
                Owner = carPool.Owner,
                Notes = carPool.Notes

            };

            _dbContext.CarPools.Add(CarPool);
            _dbContext.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.Created, CarPool);
        }


        [Route("Carpool/get")]
        [HttpGet]
        public IEnumerable<CarPool> CarPoolView()
        {
           // IList<CarPool> Car = null;

            {
                return (from p in _dbContext.CarPools  select p).ToList().Select(p=>new  CarPool { DepartureTime = p.DepartureTime,
                ExpectedArrivaltime=p.ExpectedArrivaltime,
                AvailableSeats=p.AvailableSeats,
                DaysAvailable=p.DaysAvailable,
                Destination=p.Destination,
                Notes=p.Notes,
                Origin=p.Origin,
                Owner=p.Owner,
                    CarPoolID = p.CarPoolID
                });

               
              
            }

        }


        [Route("Carpool/getJoined")]
        [HttpGet]
        public IEnumerable<CarPool> CarPoolJoined()
        {
            // IList<CarPool> Car = null;


            {

              
                return (from p in _dbContext.CarPools  join e in _dbContext.RegistrationRequests on p.CarPoolID equals e.CarPoolID where e.ID==CoMuteConstants.UserId select p).ToList().Select(p => new CarPool
                {
                    DepartureTime = p.DepartureTime,
                    ExpectedArrivaltime = p.ExpectedArrivaltime,
                    AvailableSeats = (p.AvailableSeats),
                    DaysAvailable = p.DaysAvailable,
                    Destination = p.Destination,
                    Notes = p.Notes,
                    Origin = p.Origin,
                    Owner = p.Owner,
                    CarPoolID = p.CarPoolID
                });



            }

        }

        [Route("Carpool/search")]
        [HttpGet]
        public IEnumerable<CarPool> CarPoolViewSearch(string Destination)
        {
            // IList<CarPool> Car = null;

            {
                return (from p in _dbContext.CarPools where (p.Destination == Destination) select p).ToList().Select(p => new CarPool
                {
                    DepartureTime = p.DepartureTime,
                    ExpectedArrivaltime = p.ExpectedArrivaltime,
                    AvailableSeats = p.AvailableSeats,
                    DaysAvailable = p.DaysAvailable,
                    Destination = p.Destination,
                    Notes = p.Notes,
                    Origin = p.Origin,
                    Owner = p.Owner,
                    CarPoolID = p.CarPoolID
                });



            }

        }
    }
}