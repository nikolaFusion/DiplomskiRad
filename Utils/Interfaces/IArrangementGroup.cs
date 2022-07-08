using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Interfaces
{
    public interface IArrangementGroup
    {
        public int ArrangementGroupID {get; }
        public List<int> ArrangementsIDs {get; }
        public double Price {get; }
        public List<IArrangement> Arrangements {get; }

    }
}
