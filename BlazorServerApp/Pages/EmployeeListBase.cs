using BlazorApp.Models;
using BlazorApp.Models.Enum;
using BlazorServerApp.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp.Pages
{
    public class EmployeeListBase:ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employees=(await EmployeeService.GetEmployees()).ToList();
            //await Task.Run(LoadEmployees);
            //return base.OnInitializedAsync();
        }

        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee employee1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Raj",
                LastName = "Tandukar",
                Email = "test@test.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                //Department = new Department { DepartmentId = 1, DepartmentName = "Account" },
                DepartmentId=1,
                Gender = Gender.Male,
                PhotoPath = "images/riddhi.jpg"
            };
            Employee employee2 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Jar",
                LastName = "Rakundel",
                Email = "test@test.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                //Department = new Department { DepartmentId = 1, DepartmentName = "Account" },
                DepartmentId=2,
                Gender = Gender.Male,
                PhotoPath = "images/riddhi.jpg"
            };
            Employees = new List<Employee> { employee1,employee2 };
        }
    }
}
