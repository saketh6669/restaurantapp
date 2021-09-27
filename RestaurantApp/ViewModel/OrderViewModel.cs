using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestaurantApp.ViewModel
{
    public class OrderViewModel:BaseViewModel
    { 
        public OrderViewModel()
        {
            Menulist = GetMenu();
        }
    
       
       
    


     
        public List<Pick> Menulist { get; set; }

        public ICommand OrderCommand => new Command(() => Application.Current.MainPage.Navigation.PopAsync());

        private List<Pick> GetMenu()
        {
            return new List<Pick>
            {
                new Pick { Title = "The Ultimate Package" , Image="pizza", Description="prime chicken pizza with Mozzirilla cheese. ", Price="299" },
                new Pick{Title = "crazy food",Image="Burger",Description="Tandoori grill burger with extra cheese ",Price="199"},
                new Pick{Title ="tasty desert",Image="Desert",Description="waffle with swiss chocolate icecream with topins",Price="399"},
            };
        
        

        }
    }



}
