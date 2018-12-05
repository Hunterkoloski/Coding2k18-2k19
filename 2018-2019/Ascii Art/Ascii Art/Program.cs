using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascii_Art
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt;
            do
            {
                Console.WriteLine("If you would like a 1x1 square, select 1.");
                Console.WriteLine("If you would like a 3x3 square, select 2.");
                Console.WriteLine("If you would like a 4x4 square, select 3.");
                Console.WriteLine("If you would like Right Triangle number 1, select 4.");
                Console.WriteLine("If you would like Right Triangle number 2, select 5.");
                Console.WriteLine("If you would like a pyramid, select 6");
                Console.WriteLine("If you would like special number 1, select 7");
                Console.WriteLine("If you would like special number 2, select 8 NOT CURRENTLY ");
                Console.WriteLine("If you would like special number 3, select 9 NOT CURRENTLY ");
                Console.WriteLine("If you would like to leave the program. enter 10.");
                opt = int.Parse(Console.ReadLine());

                if (opt == 1)
                {
                    Console.WriteLine("x");

                    Console.ReadLine();

                }

                if (opt == 2)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write("x");


                        }
                        Console.WriteLine(" ");

                    }

                    Console.ReadLine();
                }
                if (opt == 3)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write("x");


                        }
                        Console.WriteLine(" ");

                    }

                    Console.ReadLine();
                }


                if (opt == 4)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; i > j; j++)
                        {


                            Console.Write("x");


                        }
                        Console.WriteLine(" ");

                    }

                    Console.ReadLine();
                }

                if (opt == 7)
                {
                    for (int i = 0; i < 5; i++)
                    {

                        for (int j = 0; j < 5; j++)
                        {
                            if (j == i)
                            {
                                Console.Write(" ");
                            }
                            else
                            {

                                Console.Write("x");

                            }



                        }
                        Console.WriteLine(" ");







                    }

                    Console.ReadLine();
                }


            }
            while (opt != 10);













        }
    }
}
