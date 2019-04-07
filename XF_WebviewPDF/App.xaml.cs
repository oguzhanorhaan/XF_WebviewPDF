using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_WebviewPDF.Pages;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XF_WebviewPDF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage("insert your URL here"));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
