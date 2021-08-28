using System;
using System.Collections.Generic;
using INTECLogin.ViewModels;
using Xamarin.Forms;

namespace INTECLogin.Views
{
    public partial class MainPage : ContentPage
    {
        MenuOptionButtonView lastElementSelected = new MenuOptionButtonView();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        public void Stack_Clicked(object sender, EventArgs e)
        {
            lastElementSelected.BackgroundColor = Color.White;
            var elementSelected = (MenuOptionButtonView)sender;
            elementSelected.BackgroundColor = Color.FromHex("#F9A602");
            lastElementSelected = elementSelected;
        }
    }
}
