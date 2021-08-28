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
            MenuOptionBars.Image = "https://icons.iconarchive.com/icons/flat-icons.com/flat/256/Beer-icon.png";
            MenuOptionBars.Title = "Bars";

            MenuOptionDining.Image = "https://icons.iconarchive.com/icons/icons8/windows-8/256/Household-Dining-Room-icon.png";
            MenuOptionDining.Title = "Dinning";

            MenuOptionCafe.Image = "https://icons.iconarchive.com/icons/iconsmind/outline/256/Coffee-icon.png";
            MenuOptionCafe.Title = "Cafes";

            MenuOptionNearby.Image = "https://icons.iconarchive.com/icons/paomedia/small-n-flat/256/map-marker-icon.png";
            MenuOptionNearby.Title = "Nearby";

            MenuOptionFastFood.Image = "https://icons.iconarchive.com/icons/sonya/swarm/256/Fast-Food-icon.png";
            MenuOptionFastFood.Title = "Fast Food";
            
            MenuOptionFeaturedFood.Image = "https://icons.iconarchive.com/icons/sonya/swarm/256/Pizza-icon.png";
            MenuOptionFeaturedFood.Title = "Featured";

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
