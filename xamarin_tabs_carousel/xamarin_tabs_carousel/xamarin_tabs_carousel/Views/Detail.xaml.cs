using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_tabs_carousel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentPage
    {

        public Detail(string name, string source)
        {
            InitializeComponent();
            detailName.Text = name;
            detailImage.Source = source;
            //detailImage.Source = new UriImageSource()
            //{
            //    Uri = new Uri(source)
            //};
        }
    }
}