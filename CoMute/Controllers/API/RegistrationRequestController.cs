using CoMute.Web.Models;
using CoMute.Web.Models.Constants;
using CoMute.Web.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace CoMute.Web.Controllers.API
{
    public class RegistrationRequestController : ApiController
    {


        CoMuteDBContext _dbContext = new CoMuteDBContext();

        [Route("RegistrationRequest/add")]
        [HttpPost]
        public HttpResponseMessage Post([FromBody] RegistrationRequest registrationRequest)
        {

            var RegistrationRequest = new RegistrationRequest()
            {
                ID = Guid.NewGuid().ToString(),
                Name = registrationRequest.Name,
                Surname = registrationRequest.Surname,
                PhoneNumber = registrationRequest.PhoneNumber,
                Password = registrationRequest.Password,
                EmailAddress = registrationRequest.EmailAddress
            };

            _dbContext.RegistrationRequests.Add(RegistrationRequest);
            _dbContext.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.Created, RegistrationRequest);
        }

        [Route("RegistrationRequest/Assign")]
        [HttpPost]
        public HttpResponseMessage Assign([FromBody] RegistrationRequest registrationRequest)

        {
            var userId = "";
            if (CoMuteConstants.UserId != null && CoMuteConstants.UserId != "")
            {
                userId = CoMuteConstants.UserId;
            }

           
            var obj = _dbContext.RegistrationRequests.Where(a => a.ID.Equals(userId)).FirstOrDefault();
            if (obj != null)
            {
                if (obj.CarPoolID == null)
                    obj.CarPoolID = registrationRequest.CarPoolID;
                else { obj.CarPoolID = null; }
                _dbContext.SaveChanges();
            }

            return Request.CreateResponse(HttpStatusCode.Created, obj);
        }

        [Route("RegistrationRequest/updateDetails")]
        [HttpPost]
        public HttpResponseMessage Update([FromBody] RegistrationRequest registrationRequest)

        {
            var userId = "";
            if (CoMuteConstants.UserId != null && CoMuteConstants.UserId != "")
            {
                userId = CoMuteConstants.UserId;
            }

            var obj = _dbContext.RegistrationRequests.Where(a => a.ID.Equals(userId)).FirstOrDefault();
            if (obj != null)
            {
                obj.Name = registrationRequest.Name;
                obj.Surname = registrationRequest.Surname;
                obj.PhoneNumber = registrationRequest.PhoneNumber;
                obj.EmailAddress = registrationRequest.EmailAddress;
                obj.Password = registrationRequest.Password;

                _dbContext.SaveChanges();

           
            }
            
            return Request.CreateResponse(HttpStatusCode.Created, obj);


        }
    }
}
