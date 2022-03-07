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
    public partial class TabsView : ContentView
    {
        //check if the current tab is selected
        bool _isSelected = false;

        public TabsView()
        {
            InitializeComponent();

            this.LayoutChanged += TabsView_LayoutChanged;
            
            
        }

        private void TabsView_LayoutChanged(object sender, EventArgs e)
        {
            if (IsSelected)
            {
                TheLabel.TextColor = (Color)(Application.Current.Resources["Primary"]);
                TheIcon.TextColor = (Color)(Application.Current.Resources["Primary"]);
            }
        }




        #region Bindables


        #region TabLabel
        public static readonly BindableProperty TabLabelProperty = BindableProperty.Create(nameof(TabLabel), typeof(string), typeof(TabsView), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as TabsView;
            if (newV != null && !(newV is string)) return;
            var oldTabLabel = (string)old;
            var newTabLabel = (string)newV;
            me?.TabLabelChanged(oldTabLabel, newTabLabel);
        });

        private void TabLabelChanged(string oldTabLabel, string newTabLabel)
        {
            TheLabel.Text = newTabLabel;
        }

        /// <summary>
        /// TabLabel
        /// </summary>
        public string TabLabel
        {
            get => (string)GetValue(TabLabelProperty);
            set => SetValue(TabLabelProperty, value);
        }
        #endregion


        #region IconFamily
        public static readonly BindableProperty IconFamilyProperty = BindableProperty.Create(nameof(IconFamily), typeof(string), typeof(TabsView), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as TabsView;
            if (newV != null && !(newV is string)) return;
            var oldIconFamily = (string)old;
            var newIconFamily = (string)newV;
            me?.IconFamilyChanged(oldIconFamily, newIconFamily);
        });

        private void IconFamilyChanged(string oldIconFamily, string newIconFamily)
        {
            TheIcon.FontFamily = newIconFamily;
        }

        /// <summary>
        /// IconFamily
        /// </summary>
        public string IconFamily
        {
            get => (string)GetValue(IconFamilyProperty);
            set => SetValue(IconFamilyProperty, value);
        }
        #endregion


        #region IconText
        public static readonly BindableProperty IconTextProperty = BindableProperty.Create(nameof(IconText), typeof(string), typeof(TabsView), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as TabsView;
            if (newV != null && !(newV is string)) return;
            var oldIconText = (string)old;
            var newIconText = (string)newV;
            me?.IconTextChanged(oldIconText, newIconText);
        });

        private void IconTextChanged(string oldIconText, string newIconText)
        {
            TheIcon.Text = newIconText;
        }

        /// <summary>
        /// IconText
        /// </summary>
        public string IconText
        {
            get => (string)GetValue(IconTextProperty);
            set => SetValue(IconTextProperty, value);
        }
        #endregion




        #region IsSelected
        public static readonly BindableProperty IsSelectedProperty = BindableProperty.Create(nameof(IsSelected), typeof(bool), typeof(TabsView), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as TabsView;
            if (newV != null && !(newV is bool)) return;
            var oldIsSelected = false;
            var newIsSelected = (bool)newV;
            me?.IsSelectedChanged(oldIsSelected, newIsSelected);
        });

        private void IsSelectedChanged(bool oldIsSelected, bool newIsSelected)
        {
            _isSelected = newIsSelected;
        }

        /// <summary>
        /// IsSelected
        /// </summary>
        public bool IsSelected
        {
            get => (bool)GetValue(IsSelectedProperty);
            set => SetValue(IsSelectedProperty, value);
        }



        #endregion

        #endregion

        
    }
}