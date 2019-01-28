using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queueage_The_Cowardly_Dog_HunterK
{
    class Program
    {
        static void Main(string[] args)
        {
            queue myqueue = new queue();
            int input;
            do
            {
                Console.WriteLine("***********************");
                Console.WriteLine("*** 1. Enqueue   ******");
                Console.WriteLine("*** 2. Dequeue   ******");
                Console.WriteLine("*** 3. Peek      ******");
                Console.WriteLine("*** 4. Print     ******");
                Console.WriteLine("*** Enter 5 to exit  **");
                Console.WriteLine("***********************");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Type a value that you would like to add");
                    int numb = int.Parse(Console.ReadLine());
                    myqueue.enqueue(numb);
                }

                if (input == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(myqueue.dequeue());
                }

                if (input == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(myqueue.Peek());
                }

                if (input == 4)
                {
                    myqueue.Print();
                }

            } while (input != 5);
        }

    }
}
