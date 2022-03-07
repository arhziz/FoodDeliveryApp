using FoodDeliveryApp.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodDeliveryApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        private async void SearchNav_Tapped(object sender, System.EventArgs e)
        {
            TabsView theTab = (TabsView)sender;

            //await Application.Current.MainPage.DisplayAlert("The Tab", theTab.TabLabel, "OK");
            var actionPage = Application.Current.MainPage;
            switch (theTab.TabLabel)
            {

                case "Explore":

                    
                    await AppShell.Current.GoToAsync("//HomePage",true);
                    break;

                //case "Search":

                //    await AppShell.Current.GoToAsync(nameof(SearchPage));
                //    break;
            }
        }
    }
}