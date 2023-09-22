using MiPrimerApp01.Services;
using MiPrimerApp01.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiPrimerApp01
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
