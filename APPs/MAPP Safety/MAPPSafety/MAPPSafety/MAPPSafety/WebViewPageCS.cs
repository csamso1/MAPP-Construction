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
            string[] pdfs = new string[70];
            pdfs[0] = "FM-001_Weekly_Equipment_Inspection_Form.pdf";
            pdfs[1] = "Standard_for_HSE_Policy_00-001.pdf";
            pdfs[2] = "HSE_Policy_01-001.pdf";
            pdfs[3] = "AERIAL_AND_SCISSOR_LIFTS_02-001.pdf";
            pdfs[4] = "Asbestos_Awareness_03-001.pdf";
            pdfs[5] = "ASSURED_GROUNDING_04-001.pdf";
            pdfs[6] = "BBS_Safety_Observation_Report_SOR_05-001.pdf";
            pdfs[7] = "Benzene_Safety_Awareness_06-001.pdf";
            pdfs[8] = "BLOODBORNE_PATHOGENS_07-001.pdf";
            pdfs[9] = "Concrete_Work_08-001.pdf";
            pdfs[10] = "Combined_Confined_Space_09.pdf";
            pdfs[11] = "Combined_Cranes_and_Hoists_10.pdf";
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
