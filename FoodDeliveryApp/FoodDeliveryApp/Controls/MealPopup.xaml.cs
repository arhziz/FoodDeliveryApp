using FoodDeliveryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodDeliveryApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MealPopup : ContentView
    {
        public MealPopup()
        {
            InitializeComponent();
        }

        private async void CloseMealPopupBtn_Clicked(object sender, EventArgs e)
        {
            //Hide the view
            await this.TranslateTo(Width, 0, 400, Easing.Linear); //this is been awaited.
            this.IsVisible = false;
            this.TranslationX = 0;
        }
        int count = 1;
        
        private void IncreaseCount_Clicked(object sender, EventArgs e)
        {
            count++;
            Meal theBindingC = (Meal)this.BindingContext;
            CalPrice.Text = (theBindingC.Price * count).ToString();
            CountLabel.Text = count.ToString();
        }

        private void DecreaseCount_Clicked(object sender, EventArgs e)
        {
           if (count == 1)
                return;
            count--;
            Meal theBindingC = (Meal)this.BindingContext;
            CalPrice.Text = (theBindingC.Price * count).ToString();
            CountLabel.Text = count.ToString();

        }
    }
}