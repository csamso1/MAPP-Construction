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
            pdfs[12] = "Drugs_Alchol_Prohibited_Items_11-001.pdf";
            pdfs[13] = "Combined_Electrical_Safety_12-001.pdf";
            pdfs[14] = "Emergency_Responce_Plan_13-001.pdf";
            pdfs[15] = "Combined_Health_and_Safety_Training_14.pdf";
            pdfs[16] = "Fire_Prevention_15-001.pdf";
            pdfs[17] = "First_Aid_Safety_16-001.pdf";
            pdfs[18] = "Forklifts_17-001.pdf";
            pdfs[19] = "Combined_Hand_and_Power_Tools_18.pdf";
            pdfs[20] = "Hazard_Communication_Program_19-001.pdf";
            pdfs[21] = "Hearing_Conservation_20-001.pdf";
            pdfs[22] = "Heat_Stress_21-001.pdf";
            pdfs[23] = "Housekeeping_22-001.pdf";
            pdfs[24] = "Hydrogen_Sulfide_23-001.pdf";
            pdfs[25] = "Combined_Incident_Investigation_24.pdf";
            pdfs[26] = "Combined_Task_Safety_Analysis.pdf";
            pdfs[27] = "Ladders_26-001.pdf";
            pdfs[28] = "Lead_Safety_Awareness_27-001.pdf";
            pdfs[29] = "Combined_Lockout_Tagout.pdf";
            pdfs[30] = "Personal_Protective_Equipment_PPE_29-001.pdf";
            pdfs[31] = "Combined_Process_Safety_Managment_30.pdf";
            pdfs[32] = "Respiratory_Protection_31-001.pdf";
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