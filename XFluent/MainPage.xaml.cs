using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFluent.Resources.Fonts;

namespace XFluent
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            var regular = new List<string>();
            var filled = new List<string>();
            var rand = new Random();
            for(var i = 0; i < 100; i++)
            {
                regular.Add(FluentIconsRegular.All.ElementAt(rand.Next(0, FluentIconsRegular.All.Count)));
            }
            for (var i = 0; i < 100; i++)
            {
                filled.Add(FluentIconsRegular.All.ElementAt(rand.Next(0, FluentIconsRegular.All.Count)));
            }

            BindableLayout.SetItemsSource(FilledList, filled);
            BindableLayout.SetItemsSource(RegularList, regular);
        }
    }
}
