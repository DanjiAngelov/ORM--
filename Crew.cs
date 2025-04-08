using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project78.BaseModels;

namespace project78
{
    public class Crew:BaseModel
    {
        [MaxLength(100)]
        public string Name { get; set; }
        public int? RoleId { get; set; }
        public Role? Role { get; set; } = null!;
        public ICollection<Airplane> Airplanes { get; set; } = new List<Airplane>();
    }
}
