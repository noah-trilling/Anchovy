using System;
using System.Collections.Generic;

namespace Anchovy.API.Service.Models
{
    public class Order
    {
        public int Id { get; set; }
        public ICollection<Line> Lines { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int? CookId { get; set; }
        public Cook Cook { get; set; }
        public DateTimeOffset? OrderedTimeStamp { get; set; }
        public DateTimeOffset? ClaimedTimeStamp { get; set; }
        public DateTimeOffset? CompletedTimeStamp { get; set; }
        public DateTimeOffset? CancelledTimeStamp { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}