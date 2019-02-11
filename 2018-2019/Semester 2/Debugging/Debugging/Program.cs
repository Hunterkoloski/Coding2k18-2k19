using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            int userInput = 0;
            do
            {
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("Please enter an integer value for the action you want to perform.");
                Console.WriteLine("1. Print all multiples of 3 or 5 between selected values.");
                Console.WriteLine("2. Create an array of n random integers.");
                Console.WriteLine("3. Convert Fahrenheit to Celsius.");
                Console.WriteLine("4. End the program");
                Console.WriteLine("------------------------------------------------------------------");

                userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Please enter the lower bound to check multiples:");
                        int lowerBound = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter the upper bound to check multiples:");
                        int upperBound = int.Parse(Console.ReadLine());
                        MultiplesOfThreeAndFive(lowerBound, upperBound);
                        break;
                    case 2:
                        Console.WriteLine("Please enter the number of elements you want to add to the array:");
                        int n = int.Parse(Console.ReadLine());
                        CreateArrayOfRandomIntegers(n);
                        break;
                    case 3:
                        Console.WriteLine("Please enter a floating point number representing Fahrenheit:");
                        float fahrenheit = float.Parse(Console.ReadLine());
                        ConvertFahrenheitToCelsius(fahrenheit);
                        break;
                    case 4:
                        Console.WriteLine("Thanks for using the program.");
                        break;
                    default:
                        break;
                }
            } while (userInput != 4);
        }

        /// <summary>
        /// Prints all multiples of 3 and 5 within the two bounds (inclusive)
        /// </summary>
        /// <param name="lowerBound">The lowest value to consider</param>
        /// <param name="upperBound">The highest value to consider</param>
        static void MultiplesOfThreeAndFive(int lowerBound, int upperBound)
        {
            for(int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i + " is a multiple of 3 or 5.");
                }
            }
        }

        
        /// <summary>
        /// Creates an array of random integers
        /// </summary>
        /// <param name="sizeOfArray">Size of array</param>
        static void CreateArrayOfRandomIntegers(int sizeOfArray)
        {
            int[] myArray = new int[sizeOfArray];
            for(int i = 0; i <= sizeOfArray; i++)
            {
                myArray[i] = rand.Next(0, 1000);
            }

            for(int i = 0; i < sizeOfArray; i++)
            {
                Console.WriteLine("Element " + i + " = " + myArray[i]);
            }
        }

        /// <summary>
        /// Converts a fahrenheit argument to celsius and prints
        /// </summary>
        /// <param name="fahrenheit">The fahrenheit value to convert</param>
        static void ConvertFahrenheitToCelsius(float fahrenheit)
        {
            //formula = (fahrenheit°F − 32) × (5/9) = celsius°C
            //use google to verify your input
            Console.Write(fahrenheit + " degrees Fahrenheit is ");
            float modifer = 5f / 9f;
            float celsius = (fahrenheit - 32) * modifer;
            Console.WriteLine(celsius + " degrees celsius.");
        }
    }
}
