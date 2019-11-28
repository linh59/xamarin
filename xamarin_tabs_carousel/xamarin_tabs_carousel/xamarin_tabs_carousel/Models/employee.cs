using System;
using System.Collections.Generic;
using System.Text;

namespace xamarin_tabs_carousel.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string DisplayName { get; set; }
        public string ImagePath { get; set; }

        public Employee(int employeeId, string employeeName, string imagePath)
        {
            EmployeeId = employeeId;
            DisplayName = employeeName;
            ImagePath = imagePath;
        }

        public Employee()
        {
        }
    }
}
