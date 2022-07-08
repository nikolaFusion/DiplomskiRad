using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace DTOs.Models
{
    public class TravelPlace : ITravelPlace
    {
        public int TravelPlaceID { get ; set ; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public TravelPlace(ITravelPlace travelPlace)
        {
            TravelPlaceID = travelPlace.TravelPlaceID;
            Name = travelPlace.Name;
            Country = travelPlace.Country;
            ImageUrl = travelPlace.ImageUrl;
            Description = travelPlace.Description;
        }
    }
}
