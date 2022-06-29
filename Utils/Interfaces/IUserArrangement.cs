using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Interfaces
{
    public interface IUserArrangement
    {
        public int UserArrangementID{ get; set; }
        public int ArrangementID { get; set; }
        public int UserID { get; set; }
        
    }
}
