using System;

namespace Anchovy.API.Service.Models
{
    public class Shift
    {
        public int Id { get; set; }
        public int CookId { get; set; }
        public Cook Cook { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset? EndTime { get; set; }
    }
}