﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project78.BaseModels;

namespace project78
{
    public class Role:BaseModel
    {
        [MaxLength(20)]
        public string RoleName { get; set; }
        public ICollection<Crew> Crews { get; set; } = new List<Crew>();
    }
}
