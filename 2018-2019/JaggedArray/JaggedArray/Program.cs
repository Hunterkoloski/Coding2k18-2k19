using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static int[][] jaggedArray = new int[10][];
        static void Main(string[] args)
        {
          
            for (int i = 0; i < jaggedArray.GetLength(0); i++) 
            {
                jaggedArray[i] = new int[i + 1];
                for (int j = 0; j < jaggedArray[i].Length; j++) 
                {
                    jaggedArray[i][j] = i * j;
                }
            }
            Print2DJaggedArray(jaggedArray);

        }
        static void Print2DJaggedArray(int [][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
