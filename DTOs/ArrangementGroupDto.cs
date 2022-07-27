using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace DTOs
{
    public class ArrangementGroupDto
    {
        [JsonPropertyName("arrangementGroupID")]
        public int ArrangementGroupID { get; set; }

        [JsonPropertyName("arrangementsIDs")]
        public List<int> ArrangementsIDs { get; set; }

        [JsonPropertyName("price")]
        public double Price { get; set; }

        [JsonPropertyName("arrangements")]
        public List<ArrangenemtDto> Arrangements { get; set; }

        public ArrangementGroupDto()
        {
        }
        public ArrangementGroupDto(IArrangementGroup arrangenemtGroup)
        {
            ArrangementGroupID = arrangenemtGroup.ArrangementGroupID;
            ArrangementsIDs = arrangenemtGroup.ArrangementsIDs;
            Price = arrangenemtGroup.Price;
            Arrangements = arrangenemtGroup.Arrangements.Select(x => new ArrangenemtDto(x)).ToList();
        }

    }
}
