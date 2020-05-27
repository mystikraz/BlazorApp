using BlazorApp.Models.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Models
{
   public class Employee
    {
        public int EmployeeId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public string PhotoPath { get; set; }
    }
}
