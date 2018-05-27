using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Command[] commands = new Command[11];
           
            commands[0] = new Command("dir", "returns current directory");
            commands[1] = new Command("disks", "returns all disks");
            commands[2] = new Command("is64bitop", "returns if operating system is 64 bit");
            commands[3] = new Command("is64proc", "returns if processor is 64 bit");
            commands[4] = new Command("macname", "returns name of machine");
            commands[5] = new Command("osdetail", "returns details of oparating system");
            commands[6] = new Command("osplatform", "returns oparating system platform");
            commands[7] = new Command("osversion", "returns os version");
            commands[8] = new Command("domname", "returns user domain name");
            commands[9] = new Command("username", "returns username");
            commands[10] = new Command("osdir", "returns system directory");



            while (true)
            {
                Console.WriteLine("Enter commands...");
                string userInput = Console.ReadLine();

                if (userInput == "help")
                {
                    for (int i = 0; i < commands.Length; i++)
                    {
                        Console.WriteLine(commands[i].command + " - " + commands[i].function);

                    }
                }

                switch (userInput)
                {
                    case "dir": Console.WriteLine(Environment.CurrentDirectory); break;
                    case "disks": Console.WriteLine(Environment.GetLogicalDrives()); break;
                    case "is64bitop": Console.WriteLine(Environment.Is64BitOperatingSystem); break;
                    case "is64proc": Console.WriteLine(Environment.Is64BitProcess); break;
                    case "macname": Console.WriteLine(Environment.MachineName); break;
                    case "osdetail": Console.WriteLine(Environment.OSVersion); break;
                    case "osplatform": Console.WriteLine(Environment.OSVersion.Platform); break;
                    case "osversion": Console.WriteLine(Environment.OSVersion.Version); break;
                    case "domname": Console.WriteLine(Environment.UserDomainName); break;
                    case "username": Console.WriteLine(Environment.UserName); break;
                    case "osdir": Console.WriteLine(Environment.SystemDirectory); break;
                    default: Console.WriteLine("This command doesnt exist"); break;
                }
            }
        
    }
    }
}
