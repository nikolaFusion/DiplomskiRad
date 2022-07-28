using DTOs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace DTOs
{
    public class ArrangenemtDto
    {
        public int ArrangementID { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int TravelCompanyID { get; set; }
        public int StartPlaceID { get; set; }
        public int TravelPlaceID { get; set; }
        public double Price { get; set; }
        public int SeatsInArrangement { get; set; }
        public bool OnlyAirplaneTicket { get; set; }
        public TravelCompany TravelCompany { get; set; }
        public TravelPlace TravelPlace { get; set; }
        public TravelPlace StartPlace { get; set; }

        public ArrangenemtDto(IArrangement arrangement)
        {
            ArrangementID = arrangement.ArrangementID;
            DateStart = arrangement.DateStart;
            DateEnd = arrangement.DateEnd;
            TravelCompanyID=arrangement.TravelCompanyID;
            StartPlaceID = arrangement.StartPlaceID;
            TravelPlaceID = arrangement.TravelPlaceID;
            Price = arrangement.Price;
            SeatsInArrangement = arrangement.SeatsInArrangement;
            OnlyAirplaneTicket= arrangement.OnlyAirplaneTicket;
            TravelPlace = new TravelPlace(arrangement.TravelPlace);
            TravelCompany =new TravelCompany(arrangement.TravelCompany);
        }
        
        public ArrangenemtDto()
        {

        }
    }
}
