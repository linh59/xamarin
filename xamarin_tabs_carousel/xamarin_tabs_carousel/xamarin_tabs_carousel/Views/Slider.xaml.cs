using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_tabs_carousel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Slider : ContentPage
    {
        public Slider()
        {
            InitializeComponent();
        }
        void Handle_Scrolled(object sender, Xamarin.Forms.ScrolledEventArgs e)
        {
            lblMessage.Text = "X" + e.ScrollX.ToString() + "-Y" + e.ScrollY.ToString();
        }
    }
}