using System;
using System.Collections.Generic;

namespace Anchovy.API.Service.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CrustId { get; set; }
        public Crust Crust { get; set; }
        public int SauceId { get; set; }
        public Sauce Sauce { get; set; }
        public bool MenuItem { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }
    }
}