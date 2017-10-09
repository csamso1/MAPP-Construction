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
	public partial class SafetyManualError : ContentPage
	{
		public SafetyManualError ()
		{
			InitializeComponent ();
		}

        private void Back_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}