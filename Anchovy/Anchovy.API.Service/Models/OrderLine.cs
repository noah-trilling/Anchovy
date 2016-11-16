using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Anchovy.API.Service.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int LineId { get; set; }
        public Line Line { get; set; }
    }
}