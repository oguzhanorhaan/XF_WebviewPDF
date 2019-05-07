using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XF_WebviewPDF.iOS.CustomRenderers;

[assembly: ExportRenderer(typeof(WebView), typeof(PdfWebViewRenderer))]
namespace XF_WebviewPDF.iOS.CustomRenderers
{
    public class PdfWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (NativeView != null && e.NewElement != null)
            {
                var pdfControl = NativeView as UIWebView;

                if (pdfControl == null)
                    return;

                pdfControl.ScalesPageToFit = true;
            }
        }
    }
}