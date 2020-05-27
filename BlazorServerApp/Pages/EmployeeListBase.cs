using BlazorApp.Models;
using BlazorApp.Models.Enum;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Pages
{
    public class EmployeeListBase:ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }
        protected override Task OnInitializedAsync()
        {
            LoadEmployees();
            return base.OnInitializedAsync();
        }

        private void LoadEmployees()
        {
            Employee employee1 = new Employee
            {
                EmployeeId = 1,
                Firstname = "Raj",
                Lastname = "Tandukar",
                Email = "test@test.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Department = new Department { DepartmentId = 1, DepartmentName = "Account" },
                Gender = Gender.male,
                PhotoPath = "images/riddhi.jpg"
            };
            Employee employee2 = new Employee
            {
                EmployeeId = 1,
                Firstname = "Jar",
                Lastname = "Rakundel",
                Email = "test@test.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Department = new Department { DepartmentId = 1, DepartmentName = "Account" },
                Gender = Gender.male,
                PhotoPath = "images/riddhi.jpg"
            };
            Employees = new List<Employee> { employee1,employee2 };
        }
    }
}
