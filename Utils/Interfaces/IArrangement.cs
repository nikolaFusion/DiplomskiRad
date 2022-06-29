using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Interfaces
{
    public interface IArrangement
    {
        public int ArrangementID { get; set; }
        public int TravelCompanyID { get; set; }
        public int TravelPlaceID { get; set; }
        public DateTime Date { get; set; }
    }
}
