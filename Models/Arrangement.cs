using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Models
{
    public class Arrangement : IArrangement
    {
        [Key]
        public int ArrangementID { get; set; }
        
        public DateTime Date {get; set; }
        [Required]
        public int TravelCompanyID { get; set ; }
        [Required]
        public int TravelPlaceID { get; set; }

        [NotMapped]
        public TravelCompany TravelCompany { get; set; }
        [NotMapped]
        public  TravelPlace TravelPlace { get; set; }
        [NotMapped]
        public List<UserArrangement> UserArrangements { get; set; }


    }
}
