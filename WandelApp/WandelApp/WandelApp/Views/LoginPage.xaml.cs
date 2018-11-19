using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(entryUsername.Text, entryPassword.Text);

            //if (user.checkUser())
            //{
            //    DisplayAlert("Login", "Login Succes.", "Ok");
            //}
            //else
            //{
            //    DisplayAlert("Login", "Login Not Correct, empty username and/or password", "Ok");
            //}
        }
    }
}