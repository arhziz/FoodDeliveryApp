﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodDeliveryApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MealView : ContentView
    {
        public MealView()
        {
            InitializeComponent();
        }



        #region MName
        public static readonly BindableProperty MNameProperty = BindableProperty.Create(nameof(MName), typeof(string), typeof(MealView), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as MealView;
            if (newV != null && !(newV is string)) return;
            var oldMName = (string)old;
            var newMName = (string)newV;
            me?.MNameChanged(oldMName, newMName);
        });

        private void MNameChanged(string oldMName, string newMName)
        {
            MealName.Text = newMName;
        }

        /// <summary>
        /// A bindable property
        /// </summary>
        public string MName
        {
            get => (string)GetValue(MNameProperty);
            set => SetValue(MNameProperty, value);
        }
        #endregion



        #region MImage
        public static readonly BindableProperty MImageProperty = BindableProperty.Create(nameof(MImage), typeof(ImageSource), typeof(MealView), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as MealView;
            if (newV != null && !(newV is ImageSource)) return;
            var oldMImage = (ImageSource)old;
            var newMImage = (ImageSource)newV;
            me?.MImageChanged(oldMImage, newMImage);
        });

        private void MImageChanged(ImageSource oldMImage, ImageSource newMImage)
        {
            MealImage.Source = newMImage;
        }

        /// <summary>
        /// MImage
        /// </summary>
        public ImageSource MImage
        {
            get => (ImageSource)GetValue(MImageProperty);
            set => SetValue(MImageProperty, value);
        }
        #endregion



        #region MRating
        public static readonly BindableProperty MRatingProperty = BindableProperty.Create(nameof(MRating), typeof(string), typeof(MealView), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as MealView;
            if (newV != null && !(newV is string)) return;
            var oldMRating = (string)old;
            var newMRating = (string)newV;
            me?.MRatingChanged(oldMRating, newMRating);
        });

        private void MRatingChanged(string oldMRating, string newMRating)
        {
            MealRating.Text = newMRating;
        }

        /// <summary>
        /// MRating
        /// </summary>
        public string MRating
        {
            get => (string)GetValue(MRatingProperty);
            set => SetValue(MRatingProperty, value);
        }
        #endregion



        #region MPrice
        public static readonly BindableProperty MPriceProperty = BindableProperty.Create(nameof(MPrice), typeof(string), typeof(MealView), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as MealView;
            if (newV != null && !(newV is string)) return;
            var oldMPrice = (string)old;
            var newMPrice = (string)newV;
            me?.MPriceChanged(oldMPrice, newMPrice);
        });

        private void MPriceChanged(string oldMPrice, string newMPrice)
        {
            MealPrice.Text = newMPrice;
        }

        /// <summary>
        /// MPrice
        /// </summary>
        public string MPrice
        {
            get => (string)GetValue(MPriceProperty);
            set => SetValue(MPriceProperty, value);
        }
        #endregion



    }
}