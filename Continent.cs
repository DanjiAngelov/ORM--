using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project78.BaseModels;

namespace project78
{
    public class Continent:BaseModel
    {
        [MaxLength(20)]
        public string ContinentName { get; set; }
        public ICollection<Country> Countries { get; set; } = new List<Country>();
    }
}
