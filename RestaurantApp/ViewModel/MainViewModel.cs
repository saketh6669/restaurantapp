using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace RestaurantApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Picks = GetPicks();
        }
        public List<Pick> Picks { get; set; }

        public ICommand OrderCommand => new Command(() => Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new OrderPage()));


        private  List<Pick> GetPicks()
        {
            return new List<Pick>
            {
                new Pick {Title = "Breakfast" , Image = "Breakfast", Description = "Order Our Food"},
                 new Pick {Title = "lunch" , Image = "Lunch", Description = "Delicious lunch"},
            };
        }
         

    }
    public class Pick
    {
        public string Title { get; set; }
        public string Image{ get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }


    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] String name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
