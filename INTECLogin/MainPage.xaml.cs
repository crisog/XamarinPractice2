using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace INTECLogin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            if (string.IsNullOrWhiteSpace(emailEntry.Text) || string.IsNullOrWhiteSpace(passwordEntry.Text))
            {
                await DisplayAlert("Alerta", "No pueden haber campos vacios!", "OK");
            } else
            {
                await DisplayAlert("Bienvenid@", $"Hola, {emailEntry.Text}", "OK");
            }
        }
    }
}
