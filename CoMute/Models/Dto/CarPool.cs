using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoMute.Web.Models.Dto
{
    public class CarPool
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CarPoolID { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public string DepartureTime { get; set; }
        [DataType(DataType.DateTime)]
        public string ExpectedArrivaltime { get; set; }
        [Required]
        public string Origin { get; set; }
        public string DaysAvailable { get; set; }
        [Required]
        public string Destination { get; set; }
        [Required]
        public string AvailableSeats { get; set; }
        [Required]
        public string Owner { get; set; }
        public string Notes { get; set; }
     // public virtual ICollection<RegistrationRequest> RegistrationRequests { get; set; }
    }
}

