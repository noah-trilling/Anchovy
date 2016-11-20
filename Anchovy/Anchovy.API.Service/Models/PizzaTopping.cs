﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Anchovy.API.Service.Models
{
    public class PizzaTopping
    {
        public int Id { get; set; }
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
        public int ToppingId { get; set; }
        public Topping Topping { get; set; }
    }
}