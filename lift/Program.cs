using System;

namespace Fp
{
    internal class Lift
    {
        public static void Main(string[] args)
        {
            int count = 5,floor;
            int a = 0,ch;
            Console.WriteLine("Please enter between 0 to 5");
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Please Enter floor no: ");
                Console.ForegroundColor = ConsoleColor.White;
                floor = Convert.ToInt32(Console.ReadLine());
                if (floor > 5 || floor < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter floor number between 0 to 5");
                }
                else
                {
                    if (a == floor)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You are in the same floor");
                    }
                    else if (a < floor)
                    {
                        a++;
                        while (a <= floor)
                        {
                            if (a != floor)
                            {
                                Console.WriteLine();
                                Thread.Sleep(5000);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("You have arrived floor "+a);
                                Thread.Sleep(2500);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Crossed from floor " + a);
                            }
                            else
                            {
                                Console.WriteLine();
                                Thread.Sleep(5000);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You have arrived floor " + a);
                            }
                            Thread.Sleep(1000);
                            a++;
                        }
                        a--;
                    }
                    else
                    {
                        a--;
                        while (a >= floor)
                        {
                            if (a == 0)
                            {
                                Console.WriteLine();
                                Thread.Sleep(5000);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You have arrived to Ground floor");
                            }
                            else if (a != floor)
                            {
                                Console.WriteLine();
                                Thread.Sleep(5000);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("You have arrived floor " + a);
                                Thread.Sleep(2500);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Crossed from floor " + a);
                            }
                            else
                            {
                                Console.WriteLine();
                                Thread.Sleep(5000);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You have arrived floor " + a);
                            }
                            Thread.Sleep(1000);
                            a--;
                        }
                        a++;
                    }
                }
                if (a == 0)
                {
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.WriteLine("You are in Ground floor");
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.WriteLine("You are in floor " + a);
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.ForegroundColor= ConsoleColor.White;
                Console.WriteLine("Do you want to continue[0/1]: ");
                ch=Convert.ToInt32(Console.ReadLine());
                if(ch == 0)
                {
                    break;
                }
            }
            Console.ForegroundColor= ConsoleColor.White;
        }
    }
}
