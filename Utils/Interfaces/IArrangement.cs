using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Interfaces
{
    public interface IArrangement
    {
        public int ArrangementID { get; }
        public int TravelCompanyID { get; }
        public int TravelPlaceID { get; }
        public int StartPlaceID { get; }
        public DateTime DateStart { get; }
        public DateTime? DateEnd { get; }
        public double Price { get; }
        public int SeatsInArrangement { get; }
        public bool OnlyAirplaneTicket { get; }
        public ITravelCompany TravelCompany { get; }
        public ITravelPlace TravelPlace { get; }
        public IArrangementGroup ArrangementGroup { get; }

    }
}
