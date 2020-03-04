using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security;
using System.Text;
using System.Threading.Tasks;


namespace Refactory
{
    class Program
    {
        static void Main(string[] args)
        {

            Command cm = new Command();

         
            while (true)
            {
                bool inputSucced = false;
                int inputNumber = 0;
                while (inputSucced == false)
                {
                    Console.WriteLine("[0] Get host address.\n[1] Get ip from hostname.\n[2] Local ping.\n[3] Traceroute.\n[4] Display dhcp servers");
                    char input = Console.ReadKey().KeyChar;
                    Console.WriteLine("\n");
                    inputSucced = Int32.TryParse(input.ToString(), out inputNumber);
                    if (inputSucced == false)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong input try again");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        inputSucced = true;
                    }

                }

                string inputText = "";
                switch (inputNumber)
                {
                    case 0:
                        Console.Write("Input website : ");
                        inputText = Console.ReadLine();
                        break;
                    case 1:
                        Console.Write("Input ip : ");
                        inputText = Console.ReadLine();
                        
                        break;
                    case 3:
                        Console.Write("Input ip : ");
                        inputText = Console.ReadLine();
                        break;
                }
                Console.Clear();
                Console.WriteLine(cm.Cmd(inputNumber, inputText));
                Console.ReadKey();
                Console.Clear();
            }



            //switch ()
            //{
            //    default:
            //}




        }
    }
}
