using System;

namespace Anchovy.API.Service.Models
{
    public class Shift
    {
        public int Id { get; set; }
        public int CookId { get; set; }
        public Cook Cook { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}