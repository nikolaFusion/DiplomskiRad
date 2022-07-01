using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Interfaces
{
    public interface IArrangement
    {
        public int ArrangementID { get; set; }
        public int TravelCompanyID { get; set; }
        public int TravelPlaceID { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public double Price { get; set; }
        public int SeatsInArrangement { get; set; }
        public bool OnlyAirplaneTicket { get; set; }
    }
}
