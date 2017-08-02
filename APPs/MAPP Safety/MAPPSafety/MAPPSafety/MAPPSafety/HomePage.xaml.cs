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
            PDFPicker.Items.Add("00 Standard for HSE Policy");
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