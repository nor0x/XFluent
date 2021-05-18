using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("FluentSystemIcons-Filled.ttf", Alias = "Fluent-Filled")]
[assembly: ExportFont("FluentSystemIcons-Regular.ttf", Alias = "Fluent-Regular")]
namespace XFluent
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
