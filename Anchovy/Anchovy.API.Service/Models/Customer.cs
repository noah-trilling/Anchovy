using System;
using System.Collections.Generic;

namespace Anchovy.API.Service.Models
{
    public class Customer : Person
    {
        public DateTime SignUpDate { get; set; }
        public List<Order> OrderHistory { get; set; }
    }
}