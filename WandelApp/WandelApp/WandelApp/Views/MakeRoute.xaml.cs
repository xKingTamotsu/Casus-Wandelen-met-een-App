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
    public partial class MakeRoute : ContentPage
    {
        public MakeRoute()
        {
            InitializeComponent();
        }

        private void BtnRouteMaken_OnClicked(object sender, EventArgs e) {
            Route route = new Route() {
                name = routeName.Text,
                description = routeDescription.Text,
                length = double.Parse(routeLength.Text),
                difficulty = routeDifficulty.Text,
                wheelchairAccessible = true,
                approved = false,
                createdBy = new User() {
                    username = "test@test.com",
                    password = "Test1234"
                },
                createdAt = DateTime.Now

            };
            route.MakeRoute(route);
        }
    }
}