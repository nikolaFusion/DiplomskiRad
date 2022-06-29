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
    public class TravelPlace : ITravelPlace
    {
        [Key]
        public int TravelPlaceID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        [NotMapped]
        public List<Arrangement> Arrangements { get; set; }
    }
}
