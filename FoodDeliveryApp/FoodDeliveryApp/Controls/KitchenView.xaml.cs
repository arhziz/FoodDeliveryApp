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
    public partial class KitchenView : ContentView
    {
        public KitchenView()
        {
            InitializeComponent();
        }



        #region KName
        public static readonly BindableProperty KNameProperty = BindableProperty.Create(nameof(KName), typeof(string), typeof(KitchenView), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as KitchenView;
            if (newV != null && !(newV is string)) return;
            var oldKName = (string)old;
            var newKName = (string)newV;
            me?.KNameChanged(oldKName, newKName);
        });

        private void KNameChanged(string oldKName, string newKName)
        {
            KitchenName.Text = newKName;
        }

        /// <summary>
        /// KName
        /// </summary>
        public string KName
        {
            get => (string)GetValue(KNameProperty);
            set => SetValue(KNameProperty, value);
        }
        #endregion



        #region Rating
        public static readonly BindableProperty RatingProperty = BindableProperty.Create(nameof(Rating), typeof(string), typeof(KitchenView), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as KitchenView;
            if (newV != null && !(newV is string)) return;
            var oldRating = (string)old;
            var newRating = (string)newV;
            me?.RatingChanged(oldRating, newRating);
        });

        private void RatingChanged(string oldRating, string newRating)
        {
            KitchenRating.Text = newRating;
        }

        /// <summary>
        /// Rating
        /// </summary>
        public string Rating
        {
            get => (string)GetValue(RatingProperty);
            set => SetValue(RatingProperty, value);
        }
        #endregion



        #region ImagePath
        public static readonly BindableProperty ImagePathProperty = BindableProperty.Create(nameof(ImagePath), typeof(ImageSource), typeof(KitchenView), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as KitchenView;
            if (newV != null && !(newV is ImageSource)) return;
            var oldImagePath = (ImageSource)old;
            var newImagePath = (ImageSource)newV;
            me?.ImagePathChanged(oldImagePath, newImagePath);
        });

        private void ImagePathChanged(ImageSource oldImagePath, ImageSource newImagePath)
        {
            KitchenImage.Source = newImagePath;
        }

        /// <summary>
        /// ImagePath
        /// </summary>
        public ImageSource ImagePath
        {
            get => (ImageSource)GetValue(ImagePathProperty);
            set => SetValue(ImagePathProperty, value);
        }
        #endregion



        #region SellerImage
        public static readonly BindableProperty SellerImageProperty = BindableProperty.Create(nameof(SellerImage), typeof(ImageSource), typeof(KitchenView), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as KitchenView;
            if (newV != null && !(newV is ImageSource)) return;
            var oldSellerImage = (ImageSource)old;
            var newSellerImage = (ImageSource)newV;
            me?.SellerImageChanged(oldSellerImage, newSellerImage);
        });

        private void SellerImageChanged(ImageSource oldSellerImage, ImageSource newSellerImage)
        {
            KitchenSellerImage.Source = newSellerImage;
        }

        /// <summary>
        /// Seller Image
        /// </summary>
        public ImageSource SellerImage
        {
            get => (ImageSource)GetValue(SellerImageProperty);
            set => SetValue(SellerImageProperty, value);
        }
        #endregion




    }
}