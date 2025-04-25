using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _3and5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b,k3_plus=0,k5_plus=0,k15_plus=0,nullvar;
            int trial = 0;
            Console.WriteLine(DateTime.Now.Hour+ ":" + DateTime.Now.Minute+":"+DateTime.Now.Second+"\n\nWelcome to the porgram Gettir...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("This program works with two number. It find numbers between in your numbers how many numbers can divide by 3 or 5 or 3 and 5.");
            System.Threading.Thread.Sleep(2000);
            Operation : 
            Console.Write("First Number : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Second Number : ");
            b = int.Parse(Console.ReadLine());
            ArrayList k3 = new ArrayList();
            ArrayList k5 = new ArrayList();
            ArrayList k15 = new ArrayList();
            trial = 1;
            if (a > b)
            {
                nullvar = a;
                a = b;
                b = nullvar;
            }
            else if (a == b)
            {
                b++;
            }
            trial = 3;
            for (int i = a; i < b; i++)
            {
                if (i % 3==0&&i%5!=0)
                {
                    k3_plus++;
                    k3.Add(i);
                    trial = 4;
                }
                else if (i % 5 == 0 && i%3 != 0)
                {
                    k5_plus++;
                    k5.Add(i);
                    trial = 5;
                }
                else if (i % 5 == 0 && i % 3 == 0)
                {
                    k15_plus++;
                    k15.Add(i);
                    trial = 6;
                }
            }

            Console.WriteLine();
            Console.WriteLine("We have {0} numbers in this range...",(k3_plus+k5_plus+k15_plus));
            System.Threading.Thread.Sleep(1000);
            for (int j = 0; j < 7; j++)
            {
                Console.Clear();
                Console.Write("Data is received by computer");
                
                for (int i = 0; i < 7; i++)
                {
                    System.Threading.Thread.Sleep(100);
                    Console.Write(".");
                     
                }
            }

            Console.WriteLine("\n\n***\n\n");


            int velo3 = 100, velo5 = 100, velo15 = 100;
            if (k3.Count == 0)
            {
                Console.WriteLine("==--==--==--==-=   3X   =-==--==--==--==");
                Console.WriteLine("We don't have any 3x number in this range.\n");
            }
            else
            {
                if (k3.Count < 10)
                {
                    velo3 = 200;
                }
                else
                {
                    velo3 = 5000 / k3.Count;
                }
                Console.WriteLine("==--==--==--==-=   3X   =-==--==--==--==");
                Console.WriteLine("We have {0} -3x- numbers {1} and {2}.\n", k3.Count,a,b);
                Console.Write("3X Numbers : ");
                for (int i = 0; i < k3.Count; ++i)
                {
                    System.Threading.Thread.Sleep(velo3);
                    Console.Write(k3[i]);
                    if (i != k3.Count - 1)
                    {
                        Console.Write("-");
                    }
                }
            }
            Console.WriteLine("\n\n***\n\n");


            if (k5.Count == 0)
            {
                Console.WriteLine("==--==--==--==-=   5X   =-==--==--==--==");
                Console.WriteLine("We don't have any 5x number in this range.\n");
            }
            else
            {
                if (k5.Count < 10)
                {
                    velo5 = 200;
                }
                else
                {
                    velo5 = 5000 / k5.Count;
                }
                Console.WriteLine("==--==--==--==-=   5X   =-==--==--==--==");
                Console.WriteLine("We have {0} -5x- numbers {1} and {2}.\n", k3.Count,a,b);
                Console.Write("5X Numbers : ");
                for (int i = 0; i < k5.Count; ++i)
                {
                    System.Threading.Thread.Sleep(velo5);
                    Console.Write(k5[i] );
                    if (i != k5.Count - 1)
                    {
                        Console.Write("-");
                    }
                }
            }
            Console.WriteLine("\n\n***\n\n");




            if (k15.Count == 0)
            {
                Console.WriteLine("==--==--==--==-=   15X   =-==--==--==--==");
                Console.WriteLine("We don't have any 15x number in this range.\n");
            }
            else
            {
                if (k15.Count < 10)
                {
                    velo15 = 200;
                }
                else
                {
                    velo15 = 5000 / k15.Count;
                }
                Console.WriteLine("==--==--==--==-=   15X   =-==--==--==--==");
                Console.WriteLine("We have {0} -15x- numbers between {1} and {2}.\n", k15.Count,a,b);
                Console.Write("15X Numbers : ");
                for (int i = 0; i < k15.Count; ++i)
                {
                    System.Threading.Thread.Sleep(velo15);
                    Console.Write(k15[i] );
                    if (i != k15.Count - 1)
                    {
                        Console.Write("-");
                    }
                }
            }
            Console.WriteLine("\n\n***\n\n");

            
            string deci = "Do you want to do that again?(Y/N) : ";
            int floor = 0;
            for (int pl = 0; pl <5 ; pl++)
            {
                
                if (floor == 1||floor==2||floor==3)
                {
                    Console.Write("*  ");
                    System.Threading.Thread.Sleep(25);
                    if (floor == 2)
                    {
                        Console.Write(" ");
                        foreach (char x in deci)
                        {
                            Console.Write(x);
                            System.Threading.Thread.Sleep(25);
                        }
                        Console.Write(" ");
                    }
                    else
                    {
                        for (int i = 0; i < deci.Length+2; i++)
                        {
                            Console.Write(" ");
                        }
                    }
                    System.Threading.Thread.Sleep(25);
                    Console.WriteLine("  *");
                }
                else
                {
                    for (int pl2 = 0; pl2 <deci.Length+8; pl2++)
                    {
                        Console.Write("*");
                        System.Threading.Thread.Sleep(25);
                    }

                    Console.WriteLine();
                }
                floor++;


            }

            Console.Write("\n\n\n- ");
            
            char dec = char.Parse(Console.ReadLine());
            
            switch (dec)
            {
                case 'Y':
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Clear();
                        Console.Write("You redirecting by computer");

                        for (int i = 0; i < 10; i++)
                        {
                            System.Threading.Thread.Sleep(50);
                            Console.Write(".");

                        }
                    }

                    Console.WriteLine();
                    goto Operation;
                
                default:

                    break;
                    


            }
            Console.WriteLine("Have a nice day...\n");
            Console.ReadLine();




        }
    }
}
