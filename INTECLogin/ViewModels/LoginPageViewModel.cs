using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using INTECLogin.Models;
using INTECLogin.Views;

namespace INTECLogin.ViewModels
{
    public class LoginPageViewModel
    {
        public User User { get; set; } = new User();
        public bool IsPassword { get; set; }
        public string Image { get; set; } = "Icon";
        public ICommand LoginCommand { get; set; }
        public ICommand SignUpCommand { get; set; }
        public ICommand PasswordVisibilityCommand { get; set; }
        public LoginPageViewModel()
        {
            LoginCommand = new Command(async () =>
            {
                if (!string.IsNullOrEmpty(User.Username) && !string.IsNullOrEmpty(User.Password))
                {
                    await App.Current.MainPage.Navigation.PushAsync(new MainPage());
                }

                else
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "Todos los campos deben estar llenos.", "OK");
                }

            });

            SignUpCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
            });

            PasswordVisibilityCommand = new Command(() =>
            {
                IsPassword = !IsPassword ? true : false;
                if (IsPassword)
                {
                    Image = "Icon";
                }
                else
                {
                    Image = "closeIcon";
                }
            });
        }
    }
}
