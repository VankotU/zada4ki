﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVegans.Model
{
    public class Vegans
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int VeganTypeId { get; set; }
        public VeganType Types { get; set; }
    }
}
