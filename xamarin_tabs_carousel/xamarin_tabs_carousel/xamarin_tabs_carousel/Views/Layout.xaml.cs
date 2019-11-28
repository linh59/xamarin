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
    public partial class Layout : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employee { get { return Employee; } }
        public Layout()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = employees;

            // ObservableCollection allows items to be added after ItemsSource
            // is set and the UI will react to changes
            employees.Add(new Employee { DisplayName = "Rob Finnerty", ImagePath = "malecostume.png" });
            employees.Add(new Employee { DisplayName = "Bill Wrestler", ImagePath = "xamarin_logo.png" });
            employees.Add(new Employee { DisplayName = "Dr. Geri-Beth Hooper", ImagePath = "xamarin_logo.png" });
            employees.Add(new Employee { DisplayName = "Dr. Keith Joyce-Purdy", ImagePath = "xamarin_logo.png" });
            employees.Add(new Employee { DisplayName = "Sheri Spruce", ImagePath = "xamarin_logo.png" });
            employees.Add(new Employee { DisplayName = "Burt Indybrick", ImagePath = "xamarin_logo.png" });

        }
    }
}