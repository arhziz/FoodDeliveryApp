
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FoodDeliveryApp.Controls;
using System.Linq;

namespace FoodDeliveryApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            
        }

        private async void Tabbar_Tapped(object sender, System.EventArgs e)
        {
            TabsView theTab = (TabsView)sender;

            //await Application.Current.MainPage.DisplayAlert("The Tab", theTab.TabLabel, "OK");
            var actionPage = Application.Current.MainPage;
            switch (theTab.TabLabel)
            {
                
                //case "Explore":

                //    await AppShell.Current.GoToAsync(nameof(HomePage));
                //    break;

                case "Search":

                    await AppShell.Current.GoToAsync(nameof(SearchPage), false);
                    break;
            }
        }


        private async void MealNearby_Tapped(object sender, System.EventArgs e)
        {
            MealView element = (MealView)sender;

            MealPopup.BindingContext = element.BindingContext;
            FakeImage.Source = element.MImage;

            Rectangle TheOldBounds = FakePV.Bounds; 
            FakePV.Opacity = 1;
            FakePV.IsVisible = true;


            //translate the image to the top of the page;
            

            Rectangle rect = new Rectangle(
                x: 5,
                y: Height - element.Height,
                width: element.Width,
            height: element.Height * 0.7);


            

            AbsoluteLayout.SetLayoutBounds(FakePV, rect);
            FakePV.Layout(rect);
            Rectangle expandedBounds = FakePV.Bounds.Inflate(90, 60);

            await FakePV.TranslateTo( Application.Current.MainPage.Width - element.Width, element.Height - Application.Current.MainPage.Height, 500, Easing.Linear);
            //Hide the selected element
            element.Opacity = 0.01;
            //_ = FakeImage.ScaleTo(1.5, 500, Easing.Linear);

            _ = FakePV.LayoutTo(expandedBounds, 500, Easing.SinInOut);
            await FakePV.TranslateTo(0, element.Height - Application.Current.MainPage.Height, 500, Easing.Linear);
            _= FakePV.FadeTo(0, 200, Easing.Linear);
            FakePV.IsVisible = false;
            FakePV.TranslationY = 0;
            FakePV.Layout(TheOldBounds);

            //Display the popup
            _ = MealPopup.FadeTo(1, 300, Easing.Linear);
            MealPopup.IsVisible = true;
            
            
            element.Opacity = 1;






        }

        private BoxView CreateDefBoxView()
        {
            BoxView TheBox = new BoxView {
                WidthRequest = 20,
                HeightRequest = 20,
                CornerRadius = 10,
                BackgroundColor = Color.Red,
                Opacity = 0.4,
            };

            return TheBox;
        }

        private void FilterBtn_Clicked(object sender, System.EventArgs e)
        {
            Button FilterBtn = (Button)sender;
            //Application.Current.MainPage.DisplayAlert("Filter View Translation X", TheFilter.TranslationX.ToString(), "OK");
            TheFilter.TranslationX = 0;
            //Disolay the Filter view
            TheFilter.Display();
            

        }
    }
}