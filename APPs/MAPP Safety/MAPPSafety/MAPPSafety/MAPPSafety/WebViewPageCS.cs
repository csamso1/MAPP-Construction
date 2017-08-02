using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MAPPSafety
{
    public class WebViewPageCS : ContentPage
    {
        

        public WebViewPageCS(int index)
        {
            string[] pdfs = new string[2];
            pdfs[0] = "FM-001_Weekly_Equipment_Inspection_Form.pdf";
            pdfs[1] = "Standard_for_HSE_Policy_00-001.pdf";
            int pdfIndex = index;
            Padding = new Thickness(0, 20, 0, 0);
            Content = new StackLayout
            {
                Children =
                {
                    new CustomWebView
                    {
                        Uri = pdfs[pdfIndex],
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.FillAndExpand
                    }
                }
            };
        }
    }
}
