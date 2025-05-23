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
    public class Country:BaseModel
    {
        [MaxLength(100)]
        public string CountryName { get; set; }
        public int? ContinentId { get; set; }
        public Continent? Continent { get; set; } = null!;
        public ICollection<City> Cities { get; set; } = new List<City>();
    }
}
