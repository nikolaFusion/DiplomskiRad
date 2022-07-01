using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace DTOs
{
    public class FindGroupArrDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<int> TravelPlaceList { get; set; }
        public int NumberOfPeople { get; set; }
    }
}
