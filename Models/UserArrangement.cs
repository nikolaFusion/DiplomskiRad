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
    public class UserArrangement : IUserArrangement
    {
        [Key]
        public int UserArrangementID { get; set; }
        [Key]
        public int ArrangementID { get; set; }
        [Key]
        public int UserID { get; set; }

        [NotMapped]
        public Arrangement Arrangement { get; set; }
        [NotMapped]
        public User User { get; set; }
    }
}
