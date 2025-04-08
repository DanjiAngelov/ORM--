using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex88.BaseModels;

namespace ex88.Models
{
    public class cars:BaseModel
    {
        public DateTimeOffset YearOfManuFacture { get; set; }
        public string MaxSpeed { get; set; }

        public string Weight { get; set; }

        public string Height { get; set; }

        public int Length { get; set; }

        public int EngineID { get; set; }

        public Engine Engine { get; set; }

    }
}
