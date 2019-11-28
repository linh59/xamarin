using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

using xamarin_tabs_carousel.Models;
using xamarin_tabs_carousel.Services;

namespace xamarin_tabs_carousel.ViewModels
{
    public class Carousel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<BirdsModel> _birds;

       
        public Carousel()
        {
           
            _birds = new ObservableCollection<BirdsModel>();
            _birds.Add(new BirdsModel { Title = "Asian Paradise Flycatcher", ImagePath = "xamarin_logo.png" });
            _birds.Add(new BirdsModel { Title = "Sarus Crane", ImagePath = "xamarin_logo.png" });
            _birds.Add(new BirdsModel { Title = "Himalayan Monal", ImagePath = "xamarin_logo.png" });
            _birds.Add(new BirdsModel { Title = "Indian Peafowl", ImagePath = "xamarin_logo.png" });
            _birds.Add(new BirdsModel { Title = "Mrs. Gould’s Sunbird", ImagePath = "xamarin_logo.png" });
            _birds.Add(new BirdsModel { Title = "Oriental Dwarf Kingfisher", ImagePath = "xamarin_logo.png" });
            _birds.Add(new BirdsModel { Title = "Red Headed Trogon", ImagePath = "xamarin_logo.png" });

        }

        public ObservableCollection<BirdsModel> Birds
        {
            get
            {
                return _birds;
            }
            set
            {
                if (_birds != value)
                {
                    _birds = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Birds"));
                }
            }
        }


        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}