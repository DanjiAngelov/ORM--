﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project78.BaseModels;

namespace project78
{
    public class Payroll:BaseModel
    {
        public double Total { get; set; }

        // One payroll belongs to one passenger
        public int? PassengerId { get; set; }
        public Passenger? Passenger { get; set; } = null!;

        // One payroll belongs to one ticket
        public int? TicketId { get; set; }
        public Ticket? Ticket { get; set; } = null!;
    }
}
