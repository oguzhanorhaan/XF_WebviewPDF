using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XF_WebviewPDF.Droid.CustomRenderers;
using XF_WebviewPDF.Droid.Utils;

[assembly: ExportRenderer(typeof(WebView), typeof(PdfWebViewRenderer))]
namespace XF_WebviewPDF.Droid.CustomRenderers
{
    public class PdfWebViewRenderer : WebViewRenderer
    {
        public PdfWebViewRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                Control.Settings.AllowUniversalAccessFromFileURLs = true;
                Control.SetWebViewClient(new CustomWebivewClient(Control));
            }
        }

        public override bool OnKeyDown([GeneratedEnum] Keycode keyCode, KeyEvent e)
        {
            if (e.Action == KeyEventActions.Down)
            {
                switch (keyCode)
                {
                    case Keycode.Back:
                        if (Control.CanGoBack())
                        {
                            Control.GoBack();
                        }

                        return true;
                }
            }
            return base.OnKeyDown(keyCode, e);
        }
    }
}