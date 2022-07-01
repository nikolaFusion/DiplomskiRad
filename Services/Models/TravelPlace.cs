﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Services.Models
{
    public class TravelPlace : ITravelPlace
    {
        public int TravelPlaceID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public TravelPlace(ITravelPlace place)
        {
            TravelPlaceID=place.TravelPlaceID;
            Name = place.Name;
            Country = place.Country;
            ImageUrl = place.ImageUrl;
            Description = place.Description;
        }
    }
}