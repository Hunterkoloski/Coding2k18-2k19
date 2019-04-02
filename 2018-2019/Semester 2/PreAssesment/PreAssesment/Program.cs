using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_assesment
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            do
            {
                Console.WriteLine("1- Print Hello World");
                Console.WriteLine("2- Add two integers");
                Console.WriteLine("3- Calculate the area of a circle");
                Console.WriteLine("4- Calculatre area of triange");
                Console.WriteLine("5- To draw a square");
                Console.WriteLine("6- To draw a hollow square");
                Console.WriteLine("7- Swap integers");
                Console.WriteLine("8- Reverse a string");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Hello world");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Input a integer");
                        int int1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input a second integer");
                        int int2 = int.Parse(Console.ReadLine());
                        int int3 = int1 + int2;
                        Console.WriteLine(int3);
                        break;
                    case 3:
                        Console.WriteLine("Input a radius please");
                        int radius = int.Parse(Console.ReadLine());
                        double area = Math.PI * Math.Pow(radius, 2);

                        break;
                    case 4:
                        Console.WriteLine("Input side 1");
                        int side1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input side 2");
                        int side2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input side 3");
                        int side3 = int.Parse(Console.ReadLine());
                        int x = side1 + side2 + side3;
                        int s = x / 2;
                        Console.WriteLine(Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3)));
                        break;
                    case 5:
                        Console.WriteLine("Please input the width");
                        int width = int.Parse(Console.ReadLine());
                        for (int i = 0; i < width; i++)
                        {
                            Console.Write(" x");
                            for (int o = 0; o < width - 1; o++)
                            {
                                Console.Write(" x");

                            }
                            Console.WriteLine();
                        }
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Please input the width");
                        int hollow = int.Parse(Console.ReadLine());
                        for (int i = 0; i < hollow; i++)
                        {
                            for (int o = 0; o < hollow - 1; o++)
                            {
                                if (i == 0)
                                {
                                    Console.Write("X");
                                }
                                else if (i != 0 && i != hollow -1 && (o == 0 || o == hollow - 1))
                                {
                                    Console.Write("X");
                                }
                                else if (i == hollow -1)
                                {
                                    Console.Write("X");
                                }
                                else { Console.Write("  "); }
                            }
                            Console.WriteLine();
                        }
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine(" input a value to swap");
                        int yeeyee = int.Parse(Console.ReadLine());
                        Console.WriteLine("input a second value");
                        int swap = int.Parse(Console.ReadLine());
                        int rap = yeeyee;
                        yeeyee = swap;
                        swap = rap;
                        Console.WriteLine(yeeyee);
                        Console.WriteLine(swap);
                        break;
                    case 8:
                        Console.WriteLine("Please input a word");
                        string reverse = Console.ReadLine();
                        for (int i = reverse.Length - 1; i > 0; i--)
                        {
                            Console.Write(reverse[i]);
                        }
                        Console.WriteLine();
                        break;
                }

                
            } while (input != 10);
        }
    }
}

