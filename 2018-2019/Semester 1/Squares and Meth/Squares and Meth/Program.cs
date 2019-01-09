using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares_and_Meth
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenuForUserInput();
           
        }
        static void DisplayMenuForUserInput()
        {
            int input = 0;

            Console.WriteLine("*******************************");
            Console.WriteLine("*** 1. Creates a 3x3 Square");
            Console.WriteLine("*** 2. Create A square of X's ");
            Console.WriteLine("********************************");
            int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Print3x3Square;
            }
            else if (input == 2)
            {
                PrintSquareBySize;
            }
        }
        static void PrintSquareBySize(int size)
        {
           for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("X");
                }
              Console.WriteLine();
            }
        }
        // Print a 3x3 square of X's
        static void Print3x3Square()
        {
            // Declares i
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("X");
                }
            } 
        }
        
                
            
        
    }
}
