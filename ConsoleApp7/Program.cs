using System.Runtime.InteropServices;
using ConsoleApp7;
using KeyAuth;

// made by nottek
// made by nottek
// made by nottek
// made by nottek
// made by nottek
// made by nottek
// made by nottek
// made by nottek
// made by nottek
// made by nottek
// made by nottek
// made by nottek
// made by nottek
// made by nottek
// made by nottek
// made by nottek
// made by nottek
// made by nottek
// made by nottek



// need any help with this? add me on discord: n.ottek
// timezone is NAE

// C++ version soon xD
// C++ version soon xD
// C++ version soon xD
// C++ version soon xD
// C++ version soon xD
// C++ version soon xD
// C++ version soon xD








namespace loader

{
    class Program
    {

        public static api KeyAuthApp = new api(
            name: "", // Application Name
            ownerid: "", // Owner ID
            secret: "", // Application Secret
            version: "" // Application Version /*
                           //path: @"Your_Path_Here" // (OPTIONAL) see tutorial here https://www.youtube.com/watch?v=I9rxt821gMk&t=1s
        );

        static void Main(string[] args) // this is where everything happens, to view the code of stuff like antidebug, scroll down or right click on it and hit "Go to definition" 
        {

            DisableResize();


            AntiDebugCall();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            asciiart();

            Console.Title = "Spoofer Base | not logged in";

            Console.WriteLine("\n\n\n\n Connecting..");
            KeyAuthApp.init();
            Thread.Sleep(1000);
            Console.Clear();
            asciiart();
            Console.WriteLine("\n\n\n\n Connected!\n\n\n");



            Console.Write("1. Login\n2. Register\nEnter your option: ");
            string username, password, key, email;
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Write("Enter username: ");
                    username = Console.ReadLine();
                    Console.Write("Enter password: ");
                    password = Console.ReadLine();
                    KeyAuthApp.login(username, password);
                    break;
                case 2:
                    Console.Write("Enter username: ");
                    username = Console.ReadLine();
                    Console.Write("Enter password: ");
                    password = Console.ReadLine();
                    Console.Write("Enter license: ");
                    key = Console.ReadLine();
                    KeyAuthApp.register(username, password, key);
                    break;
                default:
                    Console.WriteLine("\n\n Invalid Selection");
                    Thread.Sleep(2500);
                    Environment.Exit(0);
                    break; 
            
        }



            if (!KeyAuthApp.response.success)
            {
                Console.WriteLine("\n Status: " + KeyAuthApp.response.message);
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

            Console.Clear();
            asciiart();
            

            Console.Title = "Spoofer Base | Logged in as " + KeyAuthApp.user_data.username;

            Console.Write("\n\n\n[1] Perm Spoof\n[2] Temp Spoof\n[3] Clean\n[4]Report a problem\nEnter your choice: ");


            int spooferoption = int.Parse(Console.ReadLine());
            switch (spooferoption)
            {
                case 1:
                    spoof_shit.PermSpoof();
                    break;
                case 2:
                    spoof_shit.tempspoof();
                    break;
                case 3:
                    Console.Clear();
                    spoof_shit.Clean();
                    break;
            }


            
        }







        //  scroll down for all my shit , edit it as u like


















        static void AntiDebugCall() // basic anti debug.
        {
            Nokae.DebugProtector.MainModule.IsdnSpyRun();
            Nokae.DebugProtector.MainModule.IsDebugger();

        }


        static void asciiart()
        {
            string PrintASCIIArt = @" ██▓     ▒█████   ▄▄▄      ▓█████▄ ▓█████  ██▀███      ▄▄▄▄    ▄▄▄        ██████ ▓█████ 
▓██▒    ▒██▒  ██▒▒████▄    ▒██▀ ██▌▓█   ▀ ▓██ ▒ ██▒   ▓█████▄ ▒████▄    ▒██    ▒ ▓█   ▀ 
▒██░    ▒██░  ██▒▒██  ▀█▄  ░██   █▌▒███   ▓██ ░▄█ ▒   ▒██▒ ▄██▒██  ▀█▄  ░ ▓██▄   ▒███   
▒██░    ▒██   ██░░██▄▄▄▄██ ░▓█▄   ▌▒▓█  ▄ ▒██▀▀█▄     ▒██░█▀  ░██▄▄▄▄██   ▒   ██▒▒▓█  ▄ 
░██████▒░ ████▓▒░ ▓█   ▓██▒░▒████▓ ░▒████▒░██▓ ▒██▒   ░▓█  ▀█▓ ▓█   ▓██▒▒██████▒▒░▒████▒
░ ▒░▓  ░░ ▒░▒░▒░  ▒▒   ▓▒█░ ▒▒▓  ▒ ░░ ▒░ ░░ ▒▓ ░▒▓░   ░▒▓███▀▒ ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░░░ ▒░ ░
░ ░ ▒  ░  ░ ▒ ▒░   ▒   ▒▒ ░ ░ ▒  ▒  ░ ░  ░  ░▒ ░ ▒░   ▒░▒   ░   ▒   ▒▒ ░░ ░▒  ░ ░ ░ ░  ░
  ░ ░   ░ ░ ░ ▒    ░   ▒    ░ ░  ░    ░     ░░   ░     ░    ░   ░   ▒   ░  ░  ░     ░   
    ░  ░    ░ ░        ░  ░   ░       ░  ░   ░         ░            ░  ░      ░     ░  ░
                            ░                               ░                           "; // change this to your server name or whatever you want

            Console.WriteLine(PrintASCIIArt);

        }


        static void DisableResize()
        {
            IntPtr consoleHandle = GetConsoleWindow();
            IntPtr sysMenu = GetSystemMenu(consoleHandle, false);

            if (consoleHandle != IntPtr.Zero && sysMenu != IntPtr.Zero)
            {
                DeleteMenu(sysMenu, SC_SIZE, MF_BYCOMMAND);
            }
        }





        

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool DeleteMenu(IntPtr hMenu, uint uPosition, uint uFlags);

        private const uint SC_SIZE = 0xF000;
        private const uint MF_BYCOMMAND = 0x00000000;

    }

}
