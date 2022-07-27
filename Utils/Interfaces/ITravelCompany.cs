using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Interfaces
{
    public interface ITravelCompany
    {
        public int TravelCompanyID {get;}
        public string Name {get;}

        public string ImageUrl { get; set; }

    }
}
