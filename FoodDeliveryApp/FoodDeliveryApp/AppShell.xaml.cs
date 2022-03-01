
using FoodDeliveryApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FoodDeliveryApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            //Routing.RegisterRoute(nameof(StartPage), typeof(StartPage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));

        }
    }
}
