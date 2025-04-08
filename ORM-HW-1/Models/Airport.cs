﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirCompanySystem.Models;
using project78.BaseModels;

namespace project78
{
    public class Airport:BaseModel
    {
        [MaxLength(100)]
        public string AirportName { get; set; }
        public int? CityId { get; set; }
        public City? City { get; set; } = null!;
        public ICollection<Flight> Flights { get; set; } = new List<Flight>();
    }
}
