using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Security.Principal;

namespace CheeedsResetingTool
{
    class Program
    {

        static void Main(string[] args)
        {
            Start:
            WebClient client = new WebClient();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                ▄████▄   ██░ ██ ▓█████ ▓█████ ▓█████ ▓█████▄ ");
            Console.WriteLine("               ▒██▀ ▀█  ▓██░ ██▒▓█   ▀ ▓█   ▀ ▓█   ▀ ▒██▀ ██▌");
            Console.WriteLine("               ▒▓█    ▄ ▒██▀▀██░▒███   ▒███   ▒███   ░██   █▌");
            Console.WriteLine("               ▒▓▓▄ ▄██▒░▓█ ░██ ▒▓█  ▄ ▒▓█  ▄ ▒▓█  ▄ ░▓█▄   ▌");
            Console.WriteLine("                ▓███▀ ░░▓█▒░██▓░▒████▒░▒████▒░▒████▒░▒████▓  ");
            Console.WriteLine("                 ░  ▒    ▒ ░▒░ ░ ░ ░  ░ ░ ░  ░ ░ ░  ░ ░ ▒  ▒ ");
            Console.WriteLine("               ░         ░  ░░ ░   ░      ░      ░    ░ ░  ░ ");
            Console.WriteLine("               ░ ░       ░  ░  ░   ░  ░   ░  ░   ░  ░   ░    ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome, {0}", Environment.UserName);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--- Options ---");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine("Press 1 to Download Media Creation Tool");
            Console.WriteLine("Press 2 to Download Rufus");
            string option = Console.ReadLine();
            if (option == "1")
                {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Downloading...");
                WebClient webClient = new WebClient();
                string Creationtools = @"C:\CreationTool.exe";
                webClient.DownloadFile("https://go.microsoft.com/fwlink/?LinkId=691209", Creationtools);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Downloaded succesfully");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("saved in C:");
                Console.ReadLine();
                goto Start;
            }

            if (option == "2")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Downloading...");
                WebClient webClient = new WebClient();
                string Rufus = @"C:\Rufus.exe";
                webClient.DownloadFile("https://github.com/pbatard/rufus/releases/download/v3.10/rufus-3.10.exe", Rufus);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Downloaded succesfully");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("saved in C:");
                Console.ReadLine();
                goto Start;
            }

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Number doesnt exist");
                Console.ReadLine();
                goto Start;

            }
            Console.ReadLine();
    }

        
}
}