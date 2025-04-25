using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            { 
            Console.WriteLine("Type");
            ConsoleKeyInfo ky = Console.ReadKey(true);
            Console.WriteLine($"{ky.Key} is key...");
            System.Threading.Thread.Sleep(400);
            Console.Clear();

            if (ky.Key == ConsoleKey.D0)
            {
                break;
            }

            
            }
            Console.WriteLine("FIN");
            Console.ReadLine();
        }
    }
}
