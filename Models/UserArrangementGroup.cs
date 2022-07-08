using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Models
{
    public class UserArrangementGroup : IUserArrangementGroup
    {
        [Key]
        public int UserArrangementGroupID { get; set; }
        [Key]
        public int ArrangementGroupID { get; set; }
        [Key]
        public int UserID { get; set; }

        [NotMapped]
        public ArrangementGroup ArrangementGroup { get; set; }
        [NotMapped]
        public User User { get; set; }
    }
}
