﻿using System;
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
            PDFPicker.Items.Add("13 - Emergency Response Plan");
            PDFPicker.Items.Add("14 - Health and Safety Training");
            PDFPicker.Items.Add("15 - Fire Protection");
            PDFPicker.Items.Add("16 - First Aid Safety");
            PDFPicker.Items.Add("17 - Forklifts");
            PDFPicker.Items.Add("18 - Hand and Power Tools");
            PDFPicker.Items.Add("19 - Hazard Communication");
            PDFPicker.Items.Add("20 - Hearing Conservation");
            PDFPicker.Items.Add("21 - Heat Stress");
            PDFPicker.Items.Add("22 - Housekeeping");
            PDFPicker.Items.Add("23 - Hydrogen Sulfide");
            PDFPicker.Items.Add("24 - Incident Investigation");
            PDFPicker.Items.Add("25 - Task Safety Analysis");
            PDFPicker.Items.Add("26 - Ladders");
            PDFPicker.Items.Add("27 - Lead Safety Awareness");
            PDFPicker.Items.Add("28 - Lockout Tagout");
            PDFPicker.Items.Add("29 - PPE");
            PDFPicker.Items.Add("30 - Process Safety Management");
            PDFPicker.Items.Add("31 - Respiratory Protection");
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