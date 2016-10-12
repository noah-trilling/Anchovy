using System;

namespace Anchovy.API.Service.Models
{
    public abstract class Employee : Person
    {
        public DateTime HireDateTime { get; set; }
    }
}