using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliveryApp.Models
{
    public class Meal
    {
        public string Name { get; set; }

        public List<string> Image { get; set; }

        public double Price { get; set; }

        public double Rating { get; set; }

        public List<string> Description { get; set; }
    }
}
