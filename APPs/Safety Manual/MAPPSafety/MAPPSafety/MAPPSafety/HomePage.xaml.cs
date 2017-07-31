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
        }

        private void Button_Safety_Commitment_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Safety_Manual_Pages.Commitment_Statment());
        }
    }
}