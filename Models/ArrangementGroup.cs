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
    public class ArrangementGroup:IArrangementGroup
    {
        [Key]
        [Required]
        public int ArrangementGroupID { get; set; }
        [Required]
        public List<int> ArrangementsIDs { get; set; }
        [Required]
        public double Price { get; set; }
        [NotMapped]
        public List<UserArrangementGroup> UserArrangementGroups { get; set; }
        [NotMapped]
        public List<IArrangement> Arrangements { get; set; }

        public ArrangementGroup()
        {

        }

        public ArrangementGroup(IArrangementGroup arrangementGroup)
        {
            ArrangementGroupID= arrangementGroup.ArrangementGroupID;
            ArrangementsIDs = arrangementGroup.ArrangementsIDs;
            Price = arrangementGroup.Price;
            Arrangements = arrangementGroup.Arrangements;
        }
    }
}
