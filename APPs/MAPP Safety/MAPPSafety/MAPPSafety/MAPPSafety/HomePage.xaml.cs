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
            PDFPicker.Items.Add("32 - Rigging");
            PDFPicker.Items.Add("33 - Scaffolding");
            PDFPicker.Items.Add("34 - Statement of Understanding");
            PDFPicker.Items.Add("35 - Short Service Employees");
            PDFPicker.Items.Add("36 - Compressed Gas Cylinders");
            PDFPicker.Items.Add("37 - Defensive Driving");
            PDFPicker.Items.Add("38 - Severe Weather Plan");
            PDFPicker.Items.Add("39 - Fall Protection");
            PDFPicker.Items.Add("40 - Safety Roles and Responsibilities");
            PDFPicker.Items.Add("41 - Site Visitor Control Plan");
            PDFPicker.Items.Add("42 - Trenching and Excavation");
            PDFPicker.Items.Add("43 - Welding and Cutting");
            PDFPicker.Items.Add("44 - Project Safety and Communication Signage");
            PDFPicker.Items.Add("45 - Safety Meetings");
            PDFPicker.Items.Add("46 - Materials Handling");
            PDFPicker.Items.Add("47 - Crisis Managment Plan");
            PDFPicker.Items.Add("48 - Compliance Inspection Report Form");
            PDFPicker.Items.Add("49 - Environmental Managment Plan");
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