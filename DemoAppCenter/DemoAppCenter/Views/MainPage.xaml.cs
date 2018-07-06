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
                throw new Exception("errore");
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
            }
        }
    }
}