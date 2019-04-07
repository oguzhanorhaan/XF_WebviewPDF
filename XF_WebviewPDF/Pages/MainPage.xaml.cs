using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF_WebviewPDF.Pages
{
    public partial class MainPage : ContentPage
    {
        public static ActivityIndicator MyActivityIndicator;
        public MainPage(string TargetUrl)
        {
            InitializeComponent();
            MyActivityIndicator = myActivityIndicator;
            InitWebView(TargetUrl);
        }

        private void InitWebView(string TargetUrl)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                webView.IsVisible = false;
                myActivityIndicator.IsRunning = true;
            }
            webView.Source = TargetUrl;
            webView.Navigating += WebViewNavigating;
            webView.Navigated += WebviewNavigated;

        }

        private void WebViewNavigating(object sender, WebNavigatingEventArgs args)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                webView.IsVisible = false;
                myActivityIndicator.IsRunning = true;
            }
        }

        private async void WebviewNavigated(object sender, WebNavigatedEventArgs e)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                myActivityIndicator.IsRunning = false;
                webView.IsVisible = true;
            }
        }
    }
}
