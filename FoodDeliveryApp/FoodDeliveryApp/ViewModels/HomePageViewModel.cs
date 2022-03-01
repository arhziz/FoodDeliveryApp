using FoodDeliveryApp.Models;
using MvvmHelpers;
using System.Collections.ObjectModel;

namespace FoodDeliveryApp.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        public ObservableCollection<Banner> Banners { get; set; }

        public ObservableCollection<Kitchen> Kitchens { get; set; }

        public ObservableCollection<Meal> Meals { get; set; }

        public HomePageViewModel()
        {
            Banners = new ObservableCollection<Banner>();

            Kitchens = new ObservableCollection<Kitchen>();

            Meals = new ObservableCollection<Meal>();

            //Add to banners
            Banners.Add(new Banner { Image = "bestdeal2"});

            Banners.Add(new Banner { Image = "bestdeal1" });

            Banners.Add(new Banner { Image = "bestdeal" });


            //Add to Kitchen list
            Kitchens.Add(new Kitchen { Name = "Aliva Kitchen", Rating = 4.5, Image = "sushi", SellerImage = "chef1" });

            Kitchens.Add(new Kitchen { Name = "Eckart Kitchen", Rating = 4.3, Image = "food", SellerImage = "chef2" });

            //Add to Meals List

            Meals.Add(new Meal { Name = "Chicken Hawaian Pizza", Image = "pizza1", Price = 10.65, Rating= 4.5 });

            Meals.Add(new Meal { Name = "SubwaySandwich", Image = "food", Price = 6.05, Rating = 4.5 });

        }

    }
}
