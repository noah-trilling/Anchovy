using System.Collections.Generic;

namespace Anchovy.API.Service.Models
{
    public class Cook
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal HourlyWage { get; set; }
        public decimal PieceworkRate { get; set; }
        public int ManagerId { get; set; }
        public Manager Manager { get; set; }
    }
}