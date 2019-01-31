using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WandelApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WandelApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void SignInProcedure(object sender, EventArgs e) {

            User user = new User
            {
                username = entryUsername.Text,
                password = entryPassword.Text
            };

            bool userCheck = await user.checkUser(user);
            

            if (userCheck)
            {
                await DisplayAlert("Login", "Your login credentials are correct.", "Ok");
                //await Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Login", "Login Not Correct, empty username and/or password", "Ok");
            }
        }
    }
}