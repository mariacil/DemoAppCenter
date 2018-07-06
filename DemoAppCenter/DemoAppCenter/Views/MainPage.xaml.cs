using System;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoAppCenter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            try
            {
                int titolo = 2;
                Console.WriteLine((5 / (titolo - titolo)).ToString());
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
            }
        }
    }
}