using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Services.Models
{
    public class Arrangement : IArrangement
    {
        public int ArrangementID { get; set; }
        public int TravelCompanyID { get; set; }
        public int TravelPlaceID { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public double Price { get; set; }
        public int SeatsInArrangement { get; set; }
        public bool OnlyAirplaneTicket { get; set; }
        public int StartPlaceID { get; set; }

        public ITravelPlace TravelPlace { get; set; }
        public TravelPlace StartPlace { get; set; }
        public ITravelCompany TravelCompany { get; set; }

        public IArrangementGroup ArrangementGroup { get; set; }
    }
}
