using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class spoof_shit
    {
        /*public static void AsusSpoof() // doesnt work thats why its not in the code :pray:
{
    try
    {
        string taskName = "ASUS";
        string taskDescription = "green fn 🏀";
                                         //🧺
        string randomVolumeId = GenerateVolumeId();

        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = "skibnidi.bat",
            WindowStyle = ProcessWindowStyle.Hidden
        };

        Random random = new Random();
        int rndLength = 16;
        string alphanumeric = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        string randomNumber = GenerateRandomSerial(random, alphanumeric, rndLength);

        string directoryPath = @"C:\Windows\Fonts";
        using (WebClient webClient = new WebClient())
        {
            webClient.DownloadFile("http://quiv.cdn.zerocdn.com/AMIDEWINx64.EXE", @"C:\Windows\Fonts\AMIDEWINx64.EXE");
            webClient.DownloadFile("http://quiv.cdn.zerocdn.com/AMIFLDRV64.SYS", @"C:\Windows\Fonts\AMIFLDRV64.SYS");
            webClient.DownloadFile("http://quiv.cdn.zerocdn.com/fLRjT4ai_1.bat", @"C:\Windows\Fonts\ASUS.bat");

        }

        Environment.CurrentDirectory = directoryPath;
        RunCommand("AMIDEWINx64.exe", $" /SU AUTO");
        RunCommand("AMIDEWINx64.exe", $"/BS {randomNumber}");
        RunCommand("AMIDEWINx64.exe", $"/CS {randomNumber}");
        RunCommand("AMIDEWINx64.exe", $"/SS {randomNumber}");
        RunCommand("AMIDEWINx64.exe", $"/SM \"System manufacturer\"");
        RunCommand("AMIDEWINx64.exe", $"/SP \"System Product Name\"");
        RunCommand("AMIDEWINx64.exe", $"/SV \"System Version\"");
        RunCommand("AMIDEWINx64.exe", $"/SK \"SKU\"");
        RunCommand("AMIDEWINx64.exe", $"/BT \"Default string\"");
        RunCommand("AMIDEWINx64.exe", $"/BLC \"Default string\"");
        RunCommand("AMIDEWINx64.exe", $"/CM \"Default string\"");
        RunCommand("AMIDEWINx64.exe", $"/CV \"Default string\"");
        RunCommand("AMIDEWINx64.exe", $"/CA \"Default string\"");
        RunCommand("AMIDEWINx64.exe", $"/CSK \"Default string\"");
        RunCommand("AMIDEWINx64.exe", $"/SF \"To be filled by O.E.M.\"");
        RunCommand("AMIDEWINx64.exe", $"/PSN {randomNumber}");
        RunCommand("volumeid.exe", $"C: {randomVolumeId}");
        RunCommand("volumeid.exe", $"D: {randomVolumeId}");

        Thread.Sleep(5000);
        using (TaskService ts = new TaskService())
        {
            TaskDefinition td = ts.NewTask();
            td.RegistrationInfo.Description = taskDescription;

            LogonTrigger logonTrigger = new LogonTrigger();
            td.Triggers.Add(logonTrigger);

            td.Actions.Add(new ExecAction(@"C:\Windows\Fonts\ASUS.bat", null, null));

            ts.RootFolder.RegisterTaskDefinition(taskName, td);
        }

        string[] filesToDelete = { "AMIDEWINx64.EXE", "AMIFLDRV64.SYS" };
        foreach (string fileToDelete in filesToDelete)
        {
            string filePath = Path.Combine(directoryPath, fileToDelete);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
        System.Media.SystemSounds.Beep.Play();
        MessageBox.Show($"Spoofed Successfully!");
    }
    catch (Exception ex)
    {
        MessageBox.Show($"An error occurred: {ex.Message}");
    }
}
*/




        //amidewin, not putting unleaked shit for u skids. tip: u can still sell this, but its pussy shit :3 

        public static void PermSpoof()
        {
            string randomVolumeId = GenerateVolumeId();

            string directoryPath = @"C:\Windows\Fonts"; // i like this directory because u can only view fonts not anything else

            Random random = new Random();
            int rndLength = 16;
            string alphanumeric = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string randomNumber = GenerateRandomSerial(random, alphanumeric, rndLength);

            Environment.CurrentDirectory = directoryPath;

            using (WebClient webClient = new WebClient()) // for downloading
            {
                webClient.DownloadFile("http://nottek.cdn.zerocdn.com/AMIDEWINx64.EXE", Path.Combine(directoryPath, "AMIDEWINx64.EXE"));
                webClient.DownloadFile("http://nottek.cdn.zerocdn.com/amifldrv64.sys", Path.Combine(directoryPath, "amifldrv64.sys"));
                webClient.DownloadFile("http://nottek.cdn.zerocdn.com/amigendrv64.sys", Path.Combine(directoryPath, "amigendrv64.sys"));
                webClient.DownloadFile("http://nottek.cdn.zerocdn.com/Volumeid.exe", Path.Combine(directoryPath, "volumeid.exe"));
            }

            RunCommand("AMIDEWINx64.EXE", $" /SU AUTO");
            RunCommand("AMIDEWINx64.EXE", $"/BS {randomNumber}");
            RunCommand("AMIDEWINx64.EXE", $"/CS {randomNumber}");
            RunCommand("AMIDEWINx64.EXE", $"/SS {randomNumber}");
            RunCommand("AMIDEWINx64.EXE", $"/SM \"System manufacturer\"");
            RunCommand("AMIDEWINx64.EXE", $"/SP \"System Product Name\"");
            RunCommand("AMIDEWINx64.EXE", $"/SV \"System Version\"");
            RunCommand("AMIDEWINx64.EXE", $"/SK \"SKU\"");
            RunCommand("AMIDEWINx64.EXE", $"/BT \"Default string\"");
            RunCommand("AMIDEWINx64.EXE", $"/BLC \"Default string\"");
            RunCommand("AMIDEWINx64.EXE", $"/CM \"Default string\"");
            RunCommand("AMIDEWINx64.EXE", $"/CV \"Default string\"");
            RunCommand("AMIDEWINx64.EXE", $"/CA \"Default string\"");
            RunCommand("AMIDEWINx64.EXE", $"/CSK \"Default string\"");
            RunCommand("AMIDEWINx64.EXE", $"/SF \"To be filled by O.E.M.\"");
            RunCommand("AMIDEWINx64.EXE", $"/PSN {randomNumber}");
            RunCommand("volumeid.exe", $"C: {randomVolumeId}");
            RunCommand("volumeid.exe", $"D: {randomVolumeId}");   // added volumeid spoofing for u guys >.<




            // cleaning up
            Thread.Sleep(1000); // making sure the commands aren't still running before deleting, preventing errors :3
            File.Delete(Path.Combine(directoryPath, "AMIDEWINx64.exe"));
            File.Delete(Path.Combine(directoryPath, "amifldrv64,sys"));
            File.Delete(Path.Combine(directoryPath, "amigendv64.sys"));
            File.Delete(Path.Combine(directoryPath, "volumeid.exe"));
        }

        public static void Clean()
        {
            string directoryPath = @"C:\Windows\Fonts"; // yea

            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile("http://nottek.cdn.zerocdn.com/fLRjT4ai_1%20%281%29.bat", Path.Combine(directoryPath, "clean.bat"));
                // not a good cleaner, swap it

            }
            Process.Start(Path.Combine(directoryPath, "clean.bat"));



        }




        public static void tempspoof()
        {
            string directoryPath = @"C:\Windows\Fonts";
            string macpath = @"C:\Windows\Fonts\mac.bat";
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile("", Path.Combine(directoryPath, "cumnigga.sys")); // put your driver here. i don't have one for you guys, sorry!
                webClient.DownloadFile("", Path.Combine(directoryPath, "map.exe")); // just use kdmapper or something of that sort XD
                webClient.DownloadFile("http://nottek.cdn.zerocdn.com/Permament_Mac_Changer.bat", macpath); // blammeds mac changer, works great. ly blammed 
            }
            string sysFilePath = Path.Combine(directoryPath, "cumnigga.sys");
            string mapperPath = Path.Combine(directoryPath, "niggerdick.exe");


            Environment.CurrentDirectory = directoryPath;

            RunCommand("map.exe", "cumnigga.sys");


            foreach (Process proc in Process.GetProcessesByName("WmiPrvSE"))
            {
                proc.Kill();
            }


            Process.Start(macpath);

            Thread.Sleep(1000);
            File.Delete(sysFilePath);
            File.Delete(mapperPath);
            File.Delete(macpath);
        }










        // dont touch unless u know what ur doing
        private static string GenerateVolumeId() // this is perfect dont touch!
        {
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string volumeId = "";

            for (int i = 0; i < 8; i++)
            {
                if (i == 4)
                {
                    volumeId += "-";
                }
                volumeId += chars[random.Next(chars.Length)];
            }
            return volumeId;
        }
        private static string GenerateRandomSerial(Random random, string characters, int length)
        {
            char[] serial = new char[length];
            for (int i = 0; i < length; i++)
            {
                serial[i] = characters[random.Next(characters.Length)];
            }
            return new string(serial);
        }

        private static void RunCommand(string fileName, string arguments)
        {
            ProcessStartInfo psi = new ProcessStartInfo(fileName, arguments)
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };

            Process process = Process.Start(psi);
            process.WaitForExit();
        }

    }
}

