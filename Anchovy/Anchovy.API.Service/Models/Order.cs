﻿using System;
using System.Collections.Generic;

namespace Anchovy.API.Service.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Line> Lines { get; set; }
        public Customer Customer { get; set; }
        public Cook Cook { get; set; }
        public DateTime OrderedTimeStamp { get; set; }
        public DateTime ClaimedTimeStamp { get; set; }
        public DateTime CompletedTimeStamp { get; set; }
        public DateTime CancelledTimeStamp { get; set; }
        public Person CancelledBy { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}