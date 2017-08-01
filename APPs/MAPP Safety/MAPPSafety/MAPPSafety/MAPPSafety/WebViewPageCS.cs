using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MAPPSafety
{
    class WebViewPageCS : ContentPage
    {
        public WebViewPageCS()
        {
            Padding = new Thickness(0, 20, 0, 0);
            Content = new StackLayout
            {
                Children =
                {
                    new CustomWebView
                    {
                        Uri = "FM-001_Weekly_Equipment_Inspection_Form.pdf",
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.FillAndExpand
                    }
                }
            };
        }
    }
}
