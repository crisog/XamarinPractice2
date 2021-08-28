﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using INTECLogin.Models;
using INTECLogin.Views;

namespace INTECLogin.ViewModels
{
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        public User User { get; set; } = new User();
        public string DisplayErrorMessage { get; set; } = "";
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
                    DisplayErrorMessage = "Hay campos vacios!";
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

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
