using INTECLogin.Models;
using INTECLogin.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace INTECLogin.ViewModels
{
    public class MainPageViewModel
    {
        MenuOptionButtonView lastElementSelected = new MenuOptionButtonView();
        public ICommand LoginCommand { get; set; }
        public MenuOption MenuOptionBars { get; set; } = new MenuOption();
        public MenuOption MenuOptionDining { get; set; } = new MenuOption();
        public MenuOption MenuOptionCafe { get; set; } = new MenuOption();
        public MenuOption MenuOptionNearby { get; set; } = new MenuOption();
        public MenuOption MenuOptionFastFood { get; set; } = new MenuOption();
        public MenuOption MenuOptionFeaturedFood { get; set; } = new MenuOption();

        public MainPageViewModel()
        {
            MenuOptionBars.Image = "beerIcon";
            MenuOptionBars.Title = "Bares y Hoteles";

            MenuOptionDining.Image = "fineDiningIcon";
            MenuOptionDining.Title = "Cenas";

            MenuOptionCafe.Image = "cafesIcon";
            MenuOptionCafe.Title = "Cafes";

            MenuOptionNearby.Image = "nearbyIcon";
            MenuOptionNearby.Title = "Cercanos";

            MenuOptionFastFood.Image = "fastFoodIcon";
            MenuOptionFastFood.Title = "Comida rápida";
            
            MenuOptionFeaturedFood.Image = "pizzaIcon";
            MenuOptionFeaturedFood.Title = "Favoritos";

            LoginCommand = new Command<object>((sender) =>
            {
                lastElementSelected.BackgroundColor = Color.White;
                var elementSelected = (MenuOptionButtonView)sender;
                elementSelected.BackgroundColor = Color.FromHex("#F9A602");
                lastElementSelected = elementSelected;

            });
        }

    }
}
