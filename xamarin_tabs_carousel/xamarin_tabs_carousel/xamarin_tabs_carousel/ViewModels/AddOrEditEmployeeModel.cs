using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using xamarin_tabs_carousel.Models;
using xamarin_tabs_carousel.Services;
using xamarin_tabs_carousel.Views;

namespace xamarin_tabs_carousel.ViewModels
{
    public class AddOrEditEmployeeModel 
    {
        public Employee Employee { get; set; }
        //public AddEmployeePage Employee { get; internal set; }

        public AddOrEditEmployeeModel()
        {
            Employee = new Employee();
        }
    }
}