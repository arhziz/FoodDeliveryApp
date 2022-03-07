using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PancakeView;
using Xamarin.Forms.Xaml;

namespace FoodDeliveryApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FIlterView : ContentView
    {
        IList<PancakeView> SelectedCat { get; set; }
        public FIlterView()
        {
            InitializeComponent();
            SelectedCat = new List<PancakeView>();
        }
        


        private async void CloseFilter_Tapped(object sender, EventArgs e)
        {
            

            //perform animations
            await this.TranslateTo(Width,0,400, Easing.Linear); //this is been awaited.
            this.IsVisible = false;
            
        }
        private async void Cat_Tapped(object sender, EventArgs e)
        {
            var theSelectedElement = (PancakeView)sender;
            if(SelectedCat.Contains(theSelectedElement))
            {
                theSelectedElement.BackgroundColor = Color.FromHex("#f1f1f1");

                StackLayout theContent = (StackLayout)theSelectedElement.Content;
                foreach (var theChild in theContent.Children)
                {
                    Label theLabel = (Label)theChild;
                    theLabel.TextColor = Color.Gray;
                }
                SelectedCat.Remove(theSelectedElement);
            }
            else
            {
                theSelectedElement.BackgroundColor = (Color)Application.Current.Resources["Primary"];
                
                StackLayout theContent = (StackLayout)theSelectedElement.Content;
                foreach(var theChild in theContent.Children)
                {
                    Label theLabel = (Label)theChild;
                    theLabel.TextColor = Color.FromHex("#ffffff");
                }
                SelectedCat.Add(theSelectedElement);
            }

            
        }

        internal void Display()
        {
            //set the initial states of the animation
            this.Opacity = 0;
            SortByLayout.Opacity = 0;
            PriceRangeLayout.Opacity = 0;
            CategoriesLayout.Opacity = 0;
            ApplyLayout.Opacity = 0;

            SortByLayout.TranslationY += 50;
            PriceRangeLayout.TranslationY += 50;
            CategoriesLayout.TranslationY += 50;
            ApplyLayout.TranslationY += 50;


            this.FadeTo(1, 300, Easing.Linear);
            SortByLayout.FadeTo(1, 400, Easing.Linear);
            PriceRangeLayout.FadeTo(1, 500, Easing.Linear);
            CategoriesLayout.FadeTo(1, 600, Easing.Linear);
            ApplyLayout.FadeTo(1, 700, Easing.Linear);

            SortByLayout.TranslateTo(0,0, 400, Easing.Linear);
            PriceRangeLayout.TranslateTo(0, 0, 500, Easing.Linear);
            CategoriesLayout.TranslateTo(0, 0, 600, Easing.Linear);
            ApplyLayout.TranslateTo(0, 0, 700, Easing.Linear);

            this.IsVisible = true;
        }
    }
}