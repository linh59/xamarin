using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using xamarin_tabs_carousel.Models;
using xamarin_tabs_carousel.Services;

namespace xamarin_tabs_carousel.ViewModels
{
    public class EmployeeListModel
    {
        //public ICommand AddEmployeeCommand => new Command(AddEmployee);
        //public ICommand RemoveEmployeeCommand => new Command(RemoveEmployee);
        //public ICommand UpdateEmployeeCommand => new Command(UpdateEmployee);
        public ObservableCollection<Employee> Employees { get; set; }       
        //public string EmployeeName { get; set; }
        //public string SelectedEmployee { get; set; }

        public EmployeeListModel()
        {
            Employees = new ObservableCollection<Employee>();
            Employees.Add(new Employee { DisplayName = "Rob Finnerty", ImagePath = "https://avatarfiles.alphacoders.com/115/115265.png" });
            Employees.Add(new Employee { DisplayName = "Bill Wrestler", ImagePath = "imgavatar.png" });
            Employees.Add(new Employee { DisplayName = "Dr. Geri-Beth Hooper", ImagePath = "imgavatar.png" });
            Employees.Add(new Employee { DisplayName = "Dr. Keith Joyce-Purdy", ImagePath = "imgavatar.png" });
            Employees.Add(new Employee { DisplayName = "Sheri Spruce", ImagePath = "imgavatar.png" });
            Employees.Add(new Employee { DisplayName = "Burt Indybrick", ImagePath = "imgavatar.png" });

            MessagingCenter.Subscribe<AddOrEditEmployeeModel, Employee>(this, "AddOrEditEmployee", 
                (page, employee) => {
                    Employees.Add(employee);
                });
        }

        //public void AddEmployee()
        //{
        //    Employees.Add(EmployeeName);
        //}

        //public void RemoveEmployee()
        //{
        //    Employees.Remove(SelectedEmployee);
        //}

        //public void UpdateEmployee()
        //{
        //    int newIndex = Employees.IndexOf(SelectedEmployee);
        //    Employees.Remove(SelectedEmployee);

        //    Employees.Add(EmployeeName);
        //    int oldIndex = Employees.IndexOf(EmployeeName);

        //    Employees.Move(oldIndex, newIndex);
        //}
    }
}