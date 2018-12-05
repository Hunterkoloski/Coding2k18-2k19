using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            bool truFal = true;
            for (int i = 0; i < length / 2; i++)
            {
                if (palindrome[i] != palindrome[length - (i + 1)])
                {
                    truFal = false;
                    break;
                }
            }


            if (truFal)
            {
                Console.WriteLine(palindrome + "is a palindrome!");
            }
            else// else
            {
                Console.WriteLine(palindrome + " is not palindrome!");
            }
            Console.ReadLine(); 

        }
    }
}
