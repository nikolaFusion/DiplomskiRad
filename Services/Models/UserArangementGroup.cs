using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Services.Models
{
    public class UserArangementGroup : IUserArrangementGroup
    {
        public int UserArrangementGroupID { get; set; }
        public int ArrangementGroupID { get; set; }
        public int UserID { get; set; }
    }
}
