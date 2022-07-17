using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Required]
        public DateTime DateStart {get; set; }
        
        public DateTime? DateEnd { get; set; }
        [Required]
        public int TravelCompanyID { get; set ; }
        [Required]
        public int TravelPlaceID { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int SeatsInArrangement { get; set; }
        [Required]
        [DefaultValue("true")]
        public bool OnlyAirplaneTicket { get; set; }

        [NotMapped]
        public TravelCompany TravelCompany { get; set; }
        [NotMapped]
        public  TravelPlace TravelPlace { get; set; }
        [NotMapped]
        public TravelPlace StartPlace { get; set; }
        [NotMapped]
        public List<ArrangementGroup> ArrangementsGroup { get; set; }
        [NotMapped]
        public ArrangementGroup ArrangementGroup { get; set; }
        public int StartPlaceID { get ; set ; }


        ITravelCompany IArrangement.TravelCompany => TravelCompany;

        ITravelPlace IArrangement.TravelPlace => TravelPlace;

        IArrangementGroup IArrangement.ArrangementGroup => throw new NotImplementedException();
    }
}
