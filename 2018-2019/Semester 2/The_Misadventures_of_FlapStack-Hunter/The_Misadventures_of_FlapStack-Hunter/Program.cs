using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Misadventures_of_FlapStack_Hunter
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack mystack = new Stack();
            int input;
            do
            {
                Console.WriteLine("**********************");
                Console.WriteLine("*** 1. Push     ******");
                Console.WriteLine("*** 2. Pop      ******");
                Console.WriteLine("*** 3. Peek     ******");
                Console.WriteLine("*** 4. Print    ******");
                Console.WriteLine("*** Enter 5 to exit **");
                Console.WriteLine("**********************");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Type a value that you would like to add");
                    int numb = int.Parse(Console.ReadLine());
                    mystack.Push(numb);
                }

                if (input == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(mystack.Pop());
                }

                if (input == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(mystack.Peek());
                }

                if (input == 4)
                {
                    mystack.Print();
                }

            } while (input != 5);
        }
       
    }
}
