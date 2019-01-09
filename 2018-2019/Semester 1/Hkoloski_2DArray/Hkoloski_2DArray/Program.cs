using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hkoloski_2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multiDimensionalArray = new int[10, 5];
            for (int i = 0; i < multiDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
                {
                    multiDimensionalArray[i, j] = i * j;
                }
            }
            Print2DArray(multiDimensionalArray);
        }
         static void Print2DArray(int[,] Array)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.Write("| " +Array[i, j] + " |");
                }
                Console.WriteLine();
            }
            
        }
    }
}
      




