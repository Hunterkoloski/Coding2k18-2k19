using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray = new int[10];
            List<int> myIntList = new List<int>() { 0, 1, 2, 3, 4 };

            for (int i = 0; i < 10; i++)
            {
                myIntArray[i] = i;
            }
            for (int i = 0; i < 10; i++)
            {
                myIntList.Add(i);
            }

            int[] myIntArray2 = new int[10];

            int input = 1;
            int index = 0;
            Random rand = new Random();
            int myInt;
            // Picks random integer 0-9
            

            while (index <9 )           
            {
                // Console.WriteLine("Please enter a number.");
                //input = int.Parse(Console.ReadLine());
                myIntArray2[index] = myInt = rand.Next(10);
                index++;
                Console.WriteLine(index);
            }
            Console.ReadKey();
        }
    }
}
