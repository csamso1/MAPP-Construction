using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using MAPPSafety.iOS;
using MAPPSafety;
using System.Net;
using System.IO;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]
namespace MAPPSafety.iOS
{
    public class CustomWebViewRenderer : ViewRenderer<CustomWebView, UIWebView>
    {
        protected override void OnElementChanged (ElementChangedEventArgs<CustomWebView> e)
        {
            base.OnElementChanged(e);
            if(Control == null)
            {
                SetNativeControl(new UIWebView());
            }
            if (e.OldElement != null)
            {
                //cleanup
            }
            if (e.NewElement != null)
            {
                System.Diagnostics.Debug.WriteLine("TEST e.NewElement != Null");
                var customWebView = Element as CustomWebView;
                string fileName = Path.Combine(NSBundle.MainBundle.BundlePath, string.Format("Content/{0}", WebUtility.UrlEncode(customWebView.Uri)));
                Control.LoadRequest(new NSUrlRequest(new NSUrl(fileName, false)));
                Control.ScalesPageToFit = true;
                System.Diagnostics.Debug.WriteLine("fileNmae = " + fileName);
            }
        }
    }
}