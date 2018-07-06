using System;
using Xamarin.Forms;
using DemoAppCenter.Views;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DemoAppCenter
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
            AppCenter.Start("android=590cb6cb-fce2-491d-a9cc-73df432d67d9;" +
                  "ios={Y08039752-a1a3-45c8-a235-1dea153a8950}",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
