using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace DTOs
{
    public class TravelPlacesDto : ITravelPlace
    {
        public int TravelPlaceID { get ; set ; }
        public string Name { get ; set; }
        public string Country { get ; set ; }

        public TravelPlacesDto(ITravelPlace place)
        {
            TravelPlaceID = place.TravelPlaceID;
            Name = place.Name;
            Country = place.Country;
        }
    }
}
