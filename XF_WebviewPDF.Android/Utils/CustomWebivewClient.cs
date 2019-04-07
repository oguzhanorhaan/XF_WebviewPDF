using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XF_WebviewPDF.Pages;

namespace XF_WebviewPDF.Droid.Utils
{
    public class CustomWebivewClient : Android.Webkit.WebViewClient
    {
        private string pdfUrl = "";
        Android.Webkit.WebView webView;

        public CustomWebivewClient(Android.Webkit.WebView webView)
        {
            this.webView = webView;
        }

        public override bool ShouldOverrideUrlLoading(Android.Webkit.WebView view, string url)
        {
            try
            {
                if (url.EndsWith("pdf"))
                {
                    pdfUrl = url;
                    webView.LoadUrl("https://drive.google.com/viewerng/viewer?embedded=true&url=" + url);
                }
            }
            catch (Exception e)
            {

            }
            return base.ShouldOverrideUrlLoading(view, url);
        }

        public override void OnPageStarted(Android.Webkit.WebView view, string url, Bitmap favicon)
        {
            base.OnPageStarted(view, url, favicon);
            webView.Visibility = ViewStates.Gone;
            MainPage.MyActivityIndicator.IsRunning = true;
        }

        public override void OnPageFinished(Android.Webkit.WebView view, string url)
        {
            if (Android.OS.Build.VERSION.SdkInt >= Android.OS.Build.VERSION_CODES.Kitkat)
            {
                MainPage.MyActivityIndicator.IsRunning = false;
                webView.Visibility = ViewStates.Visible;
            }
            else
            {
                MainPage.MyActivityIndicator.IsRunning = false;
                webView.Visibility = ViewStates.Visible;
            }

            base.OnPageFinished(view, url);
        }
    }
}