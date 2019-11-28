using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarin_tabs_carousel.Models;
using xamarin_tabs_carousel.ViewModels;

namespace xamarin_tabs_carousel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEmployeePage : ContentPage
    {
        public AddEmployeePage(Employee employee = null)
        {
            InitializeComponent();

            if(employee != null)
            {
                ((AddOrEditEmployeeModel)BindingContext).Employee = employee;
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Employee employee = ((AddOrEditEmployeeModel)BindingContext).Employee;
            MessagingCenter.Send(this, "AddOrEditEmployee", employee);
            Navigation.PopAsync();
        }
    }
}