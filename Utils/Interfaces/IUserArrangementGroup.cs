using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Interfaces
{
    public interface IUserArrangementGroup
    {
        public int ArrangementGroupID {get;}
        public int UserID {get;}

        public IArrangementGroup ArrangementGroup { get; }
        public IUser User { get;  }

    }
}
