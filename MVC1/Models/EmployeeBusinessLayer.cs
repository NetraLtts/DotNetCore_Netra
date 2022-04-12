using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1.Models
{
    public class EmployeeBusinessLayer
    {
        public Employee GetEmployeeDetails(int EmployeeId)
        {
            Employee employee = new Employee()
            {
                EmployeeId = EmployeeId,
                Name = "Netra",
                Gender = "MALE",
                City = "Mumbai",
                Salary = 10000,
                Address = "Andheri"

            };

            return employee;
        }
    }
}