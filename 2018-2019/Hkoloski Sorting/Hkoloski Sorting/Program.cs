using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hkoloski_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int seed = 1234;
            Random rand = new Random(seed);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);
                Console.WriteLine(array[1]);
            }


            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    Console.Write(i + ", ");
                    Console.Write(j + ", ");
                    Console.Write(array[i] + ", ");
                    Console.Write(array[j] + ", ");

                    if (array[i] > array[j])
                    {
                        Console.Write("Exchange");
                        int temp = array[j];
                        array[j] = array[i];
                        array[j] = temp;
                    }
                    Console.WriteLine();


                }
            }
        }
    }
}
