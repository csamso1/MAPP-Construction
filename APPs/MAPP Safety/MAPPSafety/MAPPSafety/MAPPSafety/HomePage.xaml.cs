using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MAPPSafety
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            PDFPicker.Items.Add("General Forms");
            PDFPicker.Items.Add("00 - Standard for HSE Policy");
            PDFPicker.Items.Add("01 - HSE Policy");
            PDFPicker.Items.Add("02 - Aerial and Scissor Lifts");
            PDFPicker.Items.Add("03 - Asbestos Awareness");
            PDFPicker.Items.Add("04 - Assured Grounding");
            PDFPicker.Items.Add("05 - BBS Safety Observation Report SOR");
            PDFPicker.Items.Add("06 - Benzene");
            PDFPicker.Items.Add("07 - Bloodborne Pathogens");
            PDFPicker.Items.Add("08 - Concrete Work");
            PDFPicker.Items.Add("09 - Confined Space");
            PDFPicker.Items.Add("10 - Cranes and Hoists");
            PDFPicker.Items.Add("11 - Drugs Alchol and Prohibited Items");
            PDFPicker.Items.Add("12 - Electrical Safety");
        }

        private void Open_PDF_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WebViewPageCS(PDFPicker.SelectedIndex));
        }

        private void PDFPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int PDFPicker_Index = PDFPicker.SelectedIndex;
        }
    }
}