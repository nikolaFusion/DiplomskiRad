using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace DTOs
{
    public class ArrangementGroupDto
    {
        public int ArrangementGroupID { get; set; }
        public List<int> ArrangementsIDs { get; set; }
        public double Price { get; set; }
        public List<ArrangenemtDto> Arrangements { get; set; }

        public ArrangementGroupDto()
        {
        }
        public ArrangementGroupDto(IArrangementGroup arrangenemtGroup)
        {
            ArrangementGroupID = arrangenemtGroup.ArrangementGroupID;
            ArrangementsIDs = arrangenemtGroup.ArrangementsIDs;
            Price = arrangenemtGroup.Price;
            Arrangements = arrangenemtGroup.Arrangements.Select(x=>new ArrangenemtDto(x)).ToList();
        }

    }
}
