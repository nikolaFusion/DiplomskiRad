using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class ArrangementGroup2Dto
    {
        public int ArrangementGroupID { get; set; }
        public List<int> ArrangementsIDs { get; set; }
        public double Price { get; set; }


    }
}
