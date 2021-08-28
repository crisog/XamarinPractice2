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
    public class SignUpPageViewModel
    {
        public User User { get; set; } = new User();
        public string ErrorMessage { get; set; } = "";
        public ICommand SignUpCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        public SignUpPageViewModel()
        {

            SignUpCommand = new Command(async () =>
            {
                if (!string.IsNullOrEmpty(User.Username) && !string.IsNullOrEmpty(User.Email) && !string.IsNullOrEmpty(User.Password) && !string.IsNullOrEmpty(User.ConfirmPassword))
                {
                    await App.Current.MainPage.Navigation.PushAsync(new MainPage());
                }

                else
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "Todos los campos deben estar llenos.", "OK");
                }

            });

            LoginCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new LoginPage());

            });

        }

    }
}
