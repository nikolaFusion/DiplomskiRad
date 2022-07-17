using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Interfaces
{
    public interface ITravelPlace
    {
        public int TravelPlaceID {get;}
        public string Name {get;}
        public string Country {get;}
        public string ImageUrl {get;}
        public string Description {get;}


    }
}
