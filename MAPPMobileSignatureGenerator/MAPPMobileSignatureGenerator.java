/**
 * @author Clayton Samson
 * This program prompts for end user information and generates an appropriate HTML signature
 */
// package mappmobilesignaturegenerator;
import java.util.Scanner;
import java.io.*;

public class MAPPMobileSignatureGenerator 
{
    public static void main(String[] args) throws FileNotFoundException 
    {
        String UserName;
        String Title;
        String DirectPhoneNum;
        String WirelessPhoneNum;
        String FaxNum;
        String Office;
        System.out.println("Enter the employee's full name: ");
        Scanner sc = new Scanner(System.in);
        UserName = sc.nextLine();
        //System.out.printf("Employe name entered = %s %n", UserName);
        System.out.println("Enter the employee's job title: ");
        Title = sc.nextLine();
        System.out.println("Enter the employee's direct phone number: ");
        DirectPhoneNum = sc.nextLine();
        System.out.println("Enter the employee's wireless phone number: ");
        WirelessPhoneNum = sc.nextLine();
        System.out.println("Enter the employee's fax number: ");
        FaxNum = sc.nextLine();
        System.out.println("Enter the employee's office location (Baton Rouge, New Orleans, or Dallas): ");
        Office = sc.nextLine();
//        String FileName = "C:/Users/Clayton/Desktop/HTML Signatures";
//        FileName.concat(UserName);
//        FileName.concat(".html");
        String FileName = "C:/Users/Clayton/Desktop/HTML Signatures/".concat(UserName).concat(" Mobile Signature.html");
        PrintWriter fileWriter = new PrintWriter(FileName);
        
        if(Office.equalsIgnoreCase("Baton Rouge"))
        {
           fileWriter.println("<html>");
           fileWriter.println(" <head>");
           fileWriter.println("  <title>MAPP</title>");
           fileWriter.println(" </head>");
           fileWriter.println(" <body>");
           fileWriter.println();
           fileWriter.printf("<b><font size=\"2\" color=\"#0054a4\" face=\"Arial\">%s </font> <font size=\"2\" color=\"#696969\" face=\"Arial\">::</font> </b> <font size=\"2\" color=\"#0054a4\" face=\"Arial\"> %s</font> %n", UserName, Title);
           fileWriter.println("  <br> <br>");
           if(!DirectPhoneNum.equalsIgnoreCase("NA"))
           {
               fileWriter.printf("  <font size=\"2\" color=\"#696969\" face=\"Arial\">%s </font> <font size=\"1\" color=\"#696969\" face=\"Arial\">D I R E C T</font>%n", DirectPhoneNum);
               fileWriter.println("  <br>");
           }
           if(!WirelessPhoneNum.equalsIgnoreCase("NA"))
           {
               fileWriter.printf("  <font size=\"2\" color=\"#696969\" face=\"Arial\">%s </font> <font size=\"1\" color=\"#696969\" face=\"Arial\">W I R E L E S S</font>", WirelessPhoneNum);
               fileWriter.println("  <br>");
           }
           if(!FaxNum.equalsIgnoreCase("NA"))
           {
               fileWriter.printf("  <font size=\"2\" color=\"#696969\" face=\"Arial\">%s </font> <font size=\"1\" color=\"#696969\" face=\"Arial\">F A X</font>", FaxNum);
               fileWriter.println("  <br>");
           }
           fileWriter.println("  <font size=\"2\" color=\"#696969\" face=\"Arial\"><sup>...........................................................................</sup></font>");
           fileWriter.println("  <br>");
           fileWriter.println("  <a href=\"http://www.mappbuilt.com\"> <img src=\"http://www.mappconstruction.com/docs/mapp_logo_email2.jpg\" alt=\"MAPP Logo\"></a>");
           fileWriter.println("  <br>");
           fileWriter.println("  <font size=\"2\" color=\"#0054a4\" face=\"Arial\">344 THIRD STREET </font> <font size=\"2\" color=\"#696969\" face=\"Arial\">:: </font> <font size=\"2\" color=\"#0054a4\" face=\"Arial\">BATON ROUGE</font>");
           fileWriter.println("  <br>");
           if(!FaxNum.equalsIgnoreCase("NA"))
           {
               fileWriter.printf("  <font size=\"2\" color=\"#0054a4\" face=\"Arial\">P 225 757 0111  </font> <font size=\"2\" color=\"#696969\" face=\"Arial\">:: </font> <font size=\"2\" color=\"#0054a4\" face=\"Arial\">F %s</font>%n", FaxNum);
               fileWriter.println("  <br>");
           }
           else
           {
               fileWriter.println("  <font size=\"2\" color=\"#0054a4\" face=\"Arial\">P 225 757 0111  </font> <font size=\"2\" color=\"#696969\" face=\"Arial\">:: </font> <font size=\"2\" color=\"#0054a4\" face=\"Arial\">F 225 408 7743</font>");
               fileWriter.println("  <br>");
           }
           fileWriter.println("  <font size=\"2\" color=\"#696969\" face=\"Arial\"><sup>...........................................................................</sup></font>");
           fileWriter.println("  <br>");
           fileWriter.println("  <a href=\"https://www.facebook.com/MAPP-129547004299/\"> <img src=\"http://www.mappconstruction.com/docs/image002.jpg\"></a>");
           fileWriter.println("  <a href=\"https://twitter.com/mappconstructn\"> <img src=\"http://www.mappconstruction.com/docs/image003.jpg\"></a>");
           fileWriter.println("  <a href=\"https://www.linkedin.com/company/118121\"> <img src=\"http://www.mappconstruction.com/docs/image004.jpg\"></a>");
           fileWriter.println("  <font size=\"1\" color=\"#696969\" face=\"Arial\">M A P P B U I L T . C O M</font>");
           fileWriter.println();
           fileWriter.println(" </body>");
           fileWriter.println("</html>");
           fileWriter.close();
        }
        else if(Office.equalsIgnoreCase("New Orleans"))
        {
            fileWriter.println("<html>");
            fileWriter.println(" <head>");
            fileWriter.println("  <title>MAPP</title>");
            fileWriter.println(" </head>");
            fileWriter.println(" <body>");
            fileWriter.println();
            fileWriter.printf("<b><font size=\"2\" color=\"#0054a4\" face=\"Arial\">%s </font> <font size=\"2\" color=\"#696969\" face=\"Arial\">::</font> </b> <font size=\"2\" color=\"#0054a4\" face=\"Arial\"> %s</font> %n", UserName, Title);
            fileWriter.println("  <br> <br>");
            if(!DirectPhoneNum.equalsIgnoreCase("NA"))
           {
               fileWriter.printf("  <font size=\"2\" color=\"#696969\" face=\"Arial\">%s </font> <font size=\"1\" color=\"#696969\" face=\"Arial\">D I R E C T</font>%n", DirectPhoneNum);
               fileWriter.println("  <br>");
           }
            if(! WirelessPhoneNum.equalsIgnoreCase("NA"))
            {
                fileWriter.printf("  <font size=\"2\" color=\"#696969\" face=\"Arial\">%s </font> <font size=\"1\" color=\"#696969\" face=\"Arial\">W I R E L E S S</font>", WirelessPhoneNum);
                fileWriter.println("  <br>");
            }
            if(!FaxNum.equalsIgnoreCase("NA"))
            {
                fileWriter.printf("  <font size=\"2\" color=\"#696969\" face=\"Arial\">%s </font> <font size=\"1\" color=\"#696969\" face=\"Arial\">F A X</font>", FaxNum);
                fileWriter.println("  <br>");
            }
            fileWriter.println("  <font size=\"2\" color=\"#696969\" face=\"Arial\"><sup>...........................................................................</sup></font>");
            fileWriter.println("  <br>");
            fileWriter.println("  <a href=\"http://www.mappbuilt.com\"> <img src=\"http://www.mappconstruction.com/docs/mapp_logo_email2.jpg\" alt=\"MAPP Logo\"></a>");
            fileWriter.println("  <br>");
            fileWriter.println("  <font size=\"2\" color=\"#0054a4\" face=\"Arial\">601 POYDRAS ST., STE 1715  </font> <font size=\"2\" color=\"#696969\" face=\"Arial\">:: </font> <font size=\"2\" color=\"#0054a4\" face=\"Arial\">NEW ORLEANS</font>");
            fileWriter.println("  <br>");
            if(!FaxNum.equalsIgnoreCase("NA"))
            {
                fileWriter.printf("  <font size=\"2\" color=\"#0054a4\" face=\"Arial\">P 504 833 6277  </font> <font size=\"2\" color=\"#696969\" face=\"Arial\">:: </font> <font size=\"2\" color=\"#0054a4\" face=\"Arial\">F %s</font>%n", FaxNum);
                fileWriter.println("  <br>");
            }
            else
            {
                fileWriter.println("  <font size=\"2\" color=\"#0054a4\" face=\"Arial\">P 504 833 6277  </font> <font size=\"2\" color=\"#696969\" face=\"Arial\">:: </font> <font size=\"2\" color=\"#0054a4\" face=\"Arial\">F 504 833 6074</font>");
                fileWriter.println("  <br>");
            }
            fileWriter.println("  <font size=\"2\" color=\"#696969\" face=\"Arial\"><sup>...........................................................................</sup></font>");
            fileWriter.println("  <br>");
            fileWriter.println("  <a href=\"https://www.facebook.com/MAPP-129547004299/\"> <img src=\"http://www.mappconstruction.com/docs/image002.jpg\"></a>");
            fileWriter.println("  <a href=\"https://twitter.com/mappconstructn\"> <img src=\"http://www.mappconstruction.com/docs/image003.jpg\"></a>");
            fileWriter.println("  <a href=\"https://www.linkedin.com/company/118121\"> <img src=\"http://www.mappconstruction.com/docs/image004.jpg\"></a>");
            fileWriter.println("  <font size=\"1\" color=\"#696969\" face=\"Arial\">M A P P B U I L T . C O M</font>");
            fileWriter.println();
            fileWriter.println(" </body>");
            fileWriter.println("</html>");
            fileWriter.close();
        }
        else if(Office.equalsIgnoreCase("Dallas"))
        {
            fileWriter.println("<html>");
            fileWriter.println(" <head>");
            fileWriter.println("  <title>MAPP</title>");
            fileWriter.println(" </head>");
            fileWriter.println(" <body>");
            fileWriter.println();
            fileWriter.printf("<b><font size=\"2\" color=\"#0054a4\" face=\"Arial\">%s </font> <font size=\"2\" color=\"#696969\" face=\"Arial\">::</font> </b> <font size=\"2\" color=\"#0054a4\" face=\"Arial\"> %s</font> %n", UserName, Title);
            fileWriter.println("  <br> <br>");
            if(!DirectPhoneNum.equalsIgnoreCase("NA"))
           {
               fileWriter.printf("  <font size=\"2\" color=\"#696969\" face=\"Arial\">%s </font> <font size=\"1\" color=\"#696969\" face=\"Arial\">D I R E C T</font>%n", DirectPhoneNum);
               fileWriter.println("  <br>");
           }
            if(! WirelessPhoneNum.equalsIgnoreCase("NA"))
            {
                fileWriter.printf("  <font size=\"2\" color=\"#696969\" face=\"Arial\">%s </font> <font size=\"1\" color=\"#696969\" face=\"Arial\">W I R E L E S S</font>", WirelessPhoneNum);
                fileWriter.println("  <br>");
            }
            if(!FaxNum.equalsIgnoreCase("NA"))
            {
                fileWriter.printf("  <font size=\"2\" color=\"#696969\" face=\"Arial\">%s </font> <font size=\"1\" color=\"#696969\" face=\"Arial\">F A X</font>", FaxNum);
                fileWriter.println("  <br>");
            }
            fileWriter.println("  <font size=\"2\" color=\"#696969\" face=\"Arial\"><sup>...........................................................................</sup></font>");
            fileWriter.println("  <br>");
            fileWriter.println("  <a href=\"http://www.mappbuilt.com\"> <img src=\"http://www.mappconstruction.com/docs/mapp_logo_email2.jpg\" alt=\"MAPP Logo\"></a>");
            fileWriter.println("  <br>");
            fileWriter.println("  <font size=\"2\" color=\"#0054a4\" face=\"Arial\">3131 Turtle Creek Blvd., STE 500  </font> <font size=\"2\" color=\"#696969\" face=\"Arial\">:: </font> <font size=\"2\" color=\"#0054a4\" face=\"Arial\">DALLAS</font>");
            fileWriter.println("  <br>");
            if(!FaxNum.equalsIgnoreCase("NA"))
            {
                fileWriter.printf("  <font size=\"2\" color=\"#0054a4\" face=\"Arial\">P 214 267 0700  </font> <font size=\"2\" color=\"#696969\" face=\"Arial\">:: </font> <font size=\"2\" color=\"#0054a4\" face=\"Arial\">F %s</font>%n", FaxNum);
                fileWriter.println("  <br>");
            }
            else
            {
                fileWriter.println("  <font size=\"2\" color=\"#0054a4\" face=\"Arial\">P 214 267 0700  </font> <font size=\"2\" color=\"#696969\" face=\"Arial\">:: </font> <font size=\"2\" color=\"#0054a4\" face=\"Arial\">F 214 267 0705</font>");
                fileWriter.println("  <br>");
            }
            fileWriter.println("  <font size=\"2\" color=\"#696969\" face=\"Arial\"><sup>...........................................................................</sup></font>");
            fileWriter.println("  <br>");
            fileWriter.println("  <a href=\"https://www.facebook.com/MAPP-129547004299/\"> <img src=\"http://www.mappconstruction.com/docs/image002.jpg\"></a>");
            fileWriter.println("  <a href=\"https://twitter.com/mappconstructn\"> <img src=\"http://www.mappconstruction.com/docs/image003.jpg\"></a>");
            fileWriter.println("  <a href=\"https://www.linkedin.com/company/118121\"> <img src=\"http://www.mappconstruction.com/docs/image004.jpg\"></a>");
            fileWriter.println("  <font size=\"1\" color=\"#696969\" face=\"Arial\">M A P P B U I L T . C O M</font>");
            fileWriter.println();
            fileWriter.println(" </body>");
            fileWriter.println("</html>");
            fileWriter.close();
        }
        else
            System.out.print("Error: invalad office entered, please try running the program again.");
    }
}