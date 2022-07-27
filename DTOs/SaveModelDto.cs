using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class SaveModelDto
    {
        public int ID { get; set; }
        public List<int> IDs { get; set; }
        public double Price { get; set; }
    }
}
