using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using xamarin_tabs_carousel.Models;
using xamarin_tabs_carousel.Views;
using xamarin_tabs_carousel.ViewModels;
using System.Collections.ObjectModel;

namespace xamarin_tabs_carousel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class List : ContentPage
    {
        public List()
        {
            InitializeComponent();
            BindingContext = new EmployeeListModel();
        }

        private async void OnItemsSelected(Object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as Employee;
            await Navigation.PushAsync(new Detail(mydetails.DisplayName, mydetails.ImagePath));
        }

        private void ToolbarItem_CLicked( object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddEmployeePage());
        }

        private void Tapped_Edit(object sneder, EventArgs e)
        {
            TappedEventArgs tappedEventArgs = (TappedEventArgs)e;

            Employee employee = ((EmployeeListModel)BindingContext).Employees.Where(emp => emp.EmployeeId == (int)tappedEventArgs.Parameter).FirstOrDefault();
            Navigation.PushAsync(new AddEmployeePage(employee));
        }
    }
}