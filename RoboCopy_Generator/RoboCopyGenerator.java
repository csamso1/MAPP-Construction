/**
 * @author Clayton Samson
 * This program prompts for source and destination locations, then generates a robocopy script to copy the files
 */
// package mappmobilesignaturegenerator;
import java.util.Scanner;
import java.io.*;

public class RoboCopyGenerator 
{
    public static void main(String[] args) throws FileNotFoundException 
    {
      //scanning in params
      String OperationDescription;
      String SourceLocation;
      String DestinationLocation;
      boolean copy = true;
      System.out.println("Enter the copy source: ");
      Scanner sc = new Scanner(System.in);
      SourceLocation = sc.nextLine();
      System.out.println("Enter the copy destination location: ");
      DestinationLocation = sc.nextLine();
      System.out.println("Is this a copy operation? (Y or N): ");
      String CopyArg = sc.nextLine();
      if(CopyArg.equalsIgnoreCase("n") || CopyArg.equalsIgnoreCase("no")){
        copy = false;
      }
      System.out.println("What is the purpose of this script?");
      OperationDescription = sc.nextLine();
      String FileName = "/mnt/c/Users/Clayton/Desktop/RoboCopy Scripts/".concat(OperationDescription).concat(".bat");
      PrintWriter fileWriter = new PrintWriter(FileName);
      fileWriter.println("@ECHO OFF");
      fileWriter.println("SETLOCAL");
      fileWriter.println();
      fileWriter.printf("SET _source=\"%s\"\n", SourceLocation);
      fileWriter.printf("SET _dest=\"%s\"\n", DestinationLocation);
      fileWriter.println();
      fileWriter.println("SET _what= /B /E /Z /FFT");
      //writing comment documentation
      fileWriter.println(":: /COPY:D :: Specifies the file properties to be copied. The following are the valid values for this option - D Data");
      fileWriter.println(":: /B :: copy files in Backup mode.");
      fileWriter.println(":: /E :: Copy Subfolders, including Empty Subfolders.");
      fileWriter.println(":: /Z :: resume the transfer of a large file in mid-file instead of restarting");
      fileWriter.println(":: /FFT :: assume FAT File Times (2-second granularity)");
      fileWriter.println();
      //back to actual script content
      if(copy == true){
        fileWriter.printf("SET _options= /R:2 /W:2 /XO /TEE /XD \"Application Data\" \"AppData\" \"Local Settings\" \"Cookies\" /LOG:\"%s\\Data_Copy-Log.txt\"\n", DestinationLocation);
      }
      else{
        fileWriter.printf("SET _options= /MOVE /R:2 /W:2 /XO /TEE /XD \"Application Data\" \"AppData\" \"Local Settings\" \"Cookies\" /LOG:\"%s\\Data_Copy-Log.txt\"\n", DestinationLocation);
      }
      //writing comment documentation
      fileWriter.println(":: /r:<N> Number of retries");
      fileWriter.println(":: /W:<N> Wait time, seconds");
      fileWriter.println(":: /TEE : Output to console window, as well as the log file");
      fileWriter.println();
      //Putting it all together
      fileWriter.print("ROBOCOPY %_source% %_dest% %_what% %_options%");
      fileWriter.close();
      System.out.printf("New Script file created: %s\n", FileName);
    }
}