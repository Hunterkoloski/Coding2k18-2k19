using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int a = rand.Next(0, 10);
            int[] array = new int[5];
            int[,] twodarray = new int[3, 4];
            int[][] jaggedArray = new int[9][];


            Print(a);
            Print(array);
            Print2dArray(twodarray);
            PrintJaggedArray(jaggedArray);
            Print(Math.PI, 8);
        }
        //Integer
        static void Print(int a)
        {
            Console.WriteLine("Integer" + a);
        }
        // Array
        static void Print(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int random = rand.Next(0, 10);
                Console.WriteLine("| " + array[i]);
            }
            Console.Write("|");
            Console.WriteLine();
        }
        // 2D-Array
        static void Print2dArray(int[,] twodarray)
        {
            for (int i = 0; i < twodarray.GetLength(0); i++)
            {
                for (int j = 0; j < twodarray.GetLength(1); j++)
                {
                    Console.Write("| " + twodarray[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        // jagged array
        static void PrintJaggedArray(int[][] jaggedarray)
        {
            Random rand = new Random();
            for (int i = 0; i < jaggedarray.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedarray[i].GetLength(i); j++)
                {
                    Console.WriteLine("| " + jaggedarray[i][j]);
                }
                Console.Write("| ");
                Console.WriteLine();
            }
        }
        static void Print(double d, int n = 2)
        {
            string printval = d.ToString("0.##");
            Console.Write(printval);
        }
    }
}

