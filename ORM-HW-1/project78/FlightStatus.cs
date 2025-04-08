﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project78.BaseModels;

namespace project78
{
    public class FlightStatus:BaseModel
    {
        [MaxLength(100)]
        public string Status { get; set; } = null!;
        public ICollection<FlightStatusChange> FlightStatusChanges { get; set; } = new List<FlightStatusChange>();
    }
}
