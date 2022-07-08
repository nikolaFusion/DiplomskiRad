using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Interfaces
{
    public interface IUserArrangementGroup
    {
        public int UserArrangementGroupID { get; set; }
        public int ArrangementGroupID { get; set; }
        public int UserID { get; set; }
        
    }
}
