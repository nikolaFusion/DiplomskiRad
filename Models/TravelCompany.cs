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
    public class TravelCompany : ITravelCompany
    {
        [Key]
        public int TravelCompanyID { get; set; }
        [Required]
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        [NotMapped]
        public List<Arrangement> Arrangements { get; set; }
    }
}
