using CoMute.Web.Models;
using CoMute.Web.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.Web.Providers.Entities;
using CoMute.Web.Models.Constants;

namespace CoMute.Web.Controllers.API
{
    [System.Web.Mvc.SessionState(System.Web.SessionState.SessionStateBehavior.Disabled)]
    public class AuthenticationController : ApiController
    {
        CoMuteDBContext _dbContext = new CoMuteDBContext();

        [Route("Authentication/login")]
        [HttpPost]
        public HttpResponseMessage Post([FromBody] LoginRequest loginRequest)

        {

            var obj = _dbContext.RegistrationRequests.Where(a => a.EmailAddress.Equals(loginRequest.Email) && a.Password.Equals(loginRequest.Password)).FirstOrDefault();
            if (obj != null)
            {
                CoMuteConstants.UserId = obj.ID;
            }

            return Request.CreateResponse(HttpStatusCode.Created, obj);

        }

        [Route("Authentication/getbyid")]
        [HttpGet]
        public IEnumerable<RegistrationRequest> CarPoolViewByID()
        {
            // IList<CarPool> Car = null;


            {
                return (from p in _dbContext.RegistrationRequests where (p.ID == CoMuteConstants.UserId) select p).ToList().Select(p => new RegistrationRequest
                {
                    Name = p.Name,
                    Surname = p.Surname,
                    EmailAddress = p.EmailAddress,
                    PhoneNumber = p.PhoneNumber,
                    Password = p.Password

                });



            }

        }
    }
}
