using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKoloski_GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set an int variable 
            int input = 0;
            // Declare a random variable
            int min = 1;
            int max = 1000;
            Random rand = new Random();
            int magicNumber = rand.Next(0, 999);
            // Set an int to 0 outside of loop and it goes up each time the loop is gone through
            int count = 0;
            // do while 
            do
            {
                count = count + 1;
                // Get the user to guess a number between 0 and 1000
                Console.WriteLine("Guess a number between "+ min+ " and " + max);

                // read the number the user inputed
                input = int.Parse(Console.ReadLine());

                if (input < 0 || input > 1001)
                {
                    Console.WriteLine("This is an Invalid Number, Please try another number");

                }
                else if (input > magicNumber)
                {
                    Console.WriteLine("This Number is too high, Try again.");
                    max = input;
                }
                else if (input < magicNumber) 
                {
                    Console.WriteLine("This Number is too low, Try again");
                    min = input;
                }
                //Tell wether the users number is higher or lower then the random number

                // Once the random number is found print the amount of guesses rquired before getting there.
            } while (input != magicNumber);

            Console.WriteLine("It Took " +  count + " Turns");




            //Tell wether the users number is higher or lower then the random number

            // Once the random number is found print the amount of guesses rquired before getting there.
        }
    }
}
