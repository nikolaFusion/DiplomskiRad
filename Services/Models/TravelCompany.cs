using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Services.Models
{
    public class TravelCompany : ITravelCompany
    {
        public int TravelCompanyID { get; set; }
        public string Name { get; set; }
    
        public TravelCompany(ITravelCompany travelCompany)
        {
            TravelCompanyID = travelCompany.TravelCompanyID;
            Name = travelCompany.Name;
        }
    }
}
