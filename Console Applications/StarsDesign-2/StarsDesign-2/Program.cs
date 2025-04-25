using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsDesign_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose your stars design\n");
            Console.WriteLine("Type 1-*\n       * *\n       * * *\n\nType 2-* * *\n       *   *\n       * * *\n\nType 3-    *\n         * * *\n       * * * * *\n         * * *\n           *\n\n");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type the max stars number :");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                for (int i = 0; i < b; i++)
                {
                    for (int j = 0; j < i + 1; j++)
                     
                        Console.Write("* ");
                        Console.WriteLine();
                    
                    
                }
            }
            if (a == 2)
            {
                for(int i = 0; i < b; i++)
                {
                   Console.Write("* ");
                
                }
                Console.WriteLine();
                for(int i = 0; i < b-2; i++)
                {
                    Console.Write("* ");
                    for(int j = 0; j < b-2; j++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write("* \n");
                }
                
                for (int i = 0; i < b; i++)
                {
                    Console.Write("* ");

                }

            }

            if (a == 3)
            {
                int c = 1;
                int p = 1;
                for (int k=0; k<b; k++)
                {
                    
                    int r = b-c ;
                    
                    for(int A = 0; A < r; A++)
                    {
                        Console.Write(" ");
                    }
                    for(int d=0; d<c; d++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                    c++;
                    
                }
                for( int i = 0; i < b; i++)
                {
                    int s = b - p;
                    for (int A = 0; A < p; A++)
                    {
                        Console.Write(" ");
                    }
                    for (int d = 0; d < s; d++)
                    {

                        Console.Write("* ");
                    }
                    Console.WriteLine();
                    p++;
                }
            }

            Console.Read();


        }
    }
}
