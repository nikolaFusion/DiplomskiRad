using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace DTOs.Models
{
    public class TravelCompany : ITravelCompany
    {
        public int TravelCompanyID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get ; set ; }

        public TravelCompany(ITravelCompany travelCompany)
        {
            TravelCompanyID = travelCompany.TravelCompanyID;
            Name = travelCompany.Name;
            ImageUrl = travelCompany.ImageUrl;
        }
    }
}
