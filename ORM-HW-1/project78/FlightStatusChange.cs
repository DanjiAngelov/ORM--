using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project78.BaseModels;

namespace project78
{
    public class FlightStatusChange:BaseModel
    {
        public int? FlightId { get; set; }
        public Flight? Flight { get; set; } = null!;
        public int? FlightStatusId { get; set; }
        public FlightStatus? FlightStatus { get; set; } = null!;
        public DateTime ChangeAt { get; set; }
    }
}
