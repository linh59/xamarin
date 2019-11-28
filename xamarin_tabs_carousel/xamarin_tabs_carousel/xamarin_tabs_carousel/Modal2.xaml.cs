using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_tabs_carousel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Modal2 : ContentPage
    {
        public Modal2(string name)
        {
            InitializeComponent();
            btnModalClick.Clicked += CloseModal_Clicked;
        }
        void CloseModal_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }
    }
}