using System;
using System.Collections.Generic;
using INTECLogin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace INTECLogin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
        }
    }
}
