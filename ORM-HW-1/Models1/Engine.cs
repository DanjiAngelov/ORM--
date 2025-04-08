using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex88.BaseModels;

namespace ex88.Models
{
    public class Engine:BaseModel
    {
        public string name { get; set; }

        public int HorsePower { get; set; }

        public int power { get; set; }

        public string FuelType { get; set; }

        public ICollection<cars> Cars { get; set; }
    }
}
