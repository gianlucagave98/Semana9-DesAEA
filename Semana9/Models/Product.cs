﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Semana9.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool Active { get; set; }
    }
}