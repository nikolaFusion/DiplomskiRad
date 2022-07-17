using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class ArrangementFilterDto
    {
        public string TravelPlaceID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int numberOfPlace { get; set; }
        public double downPrice { get; set; }
        public double upPrice { get; set; }
    }
}
