using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using xamarin_tabs.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_tabs_carousel.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            btnModalClick.Clicked += OpenModal_Clicked;
            btnModalClick_data.Clicked += OpenModalData_Clicked;
        }

        void Handle_Master_Clicked(object sender, System.EventArgs e)
        {
            this.ControlTemplate = (ControlTemplate)App.Current.Resources["ThemeMaster"];
        }
        void Handle_Master2_Clicked(object sender, System.EventArgs e)
        {
            this.ControlTemplate = (ControlTemplate)App.Current.Resources["ThemeMaster2"];
        }

        void OpenModal_Clicked(object sender, System.EventArgs e)
        {
            Modal1 modalPage = new Modal1("Linh");
            this.Navigation.PushModalAsync(modalPage);
        }
        void OpenModalData_Clicked(object sender, System.EventArgs e)
        {
            Modal2 modalPage2 = new Modal2("");
            Contact contact = new Contact()
            {
                Name = "Linh",
                Address = "HCM"
            };

            modalPage2.BindingContext = contact;
            this.Navigation.PushModalAsync(modalPage2);
        }
    }
}