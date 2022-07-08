using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Services.Models
{
    public class ArrangementGroup :IArrangementGroup
    {
        public int ArrangementGroupID { get ; set ; }
        public List<int> ArrangementsIDs { get ; set ; }
        public double Price { get ; set; }
        public List<Arrangement> Arrangements { get ; set ; }
        List<IArrangement> IArrangementGroup.Arrangements => Arrangements.ToList<IArrangement>();

        public ArrangementGroup()
        {

        }

        public ArrangementGroup(IArrangementGroup arrangementGroup)
        {
            ArrangementGroupID = arrangementGroup.ArrangementGroupID;
            ArrangementsIDs= arrangementGroup.ArrangementsIDs;
            Price=arrangementGroup.Price;
            Arrangements = arrangementGroup.Arrangements.Cast<Arrangement>().ToList();
        }

    }
}
