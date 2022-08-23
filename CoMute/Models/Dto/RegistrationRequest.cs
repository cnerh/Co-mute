using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoMute.Web.Models.Dto
{
    public class RegistrationRequest
    {
        [Key]
    //   [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public string ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        //[ForeignKey("CarPool")]
        public string CarPoolID { get; set; }
        public virtual CarPool carPool { get; set; }

        //public  ICollection<CarPool> CarPool { get; set; }
    }
}
