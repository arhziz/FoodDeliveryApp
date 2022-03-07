using FoodDeliveryApp.Models;
using MvvmHelpers;
using System.Collections.Generic;
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

            Meals.Add(new Meal { Name = "Chicken Hawaian Pizza", Image = new List<string>() { "pizza1","food" }, Price = 10.65, Rating= 4.5, Description = new List<string>() { "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters,", "1. It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters,", "2. It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters," } });

            Meals.Add(new Meal { Name = "SubwaySandwich", Image = new List<string>() { "food", "pizza1" }, Price = 6.05, Rating = 4.5, Description = new List<string>() { "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters,", "1. It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters,", "2. It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters," } });

        }

    }
}
