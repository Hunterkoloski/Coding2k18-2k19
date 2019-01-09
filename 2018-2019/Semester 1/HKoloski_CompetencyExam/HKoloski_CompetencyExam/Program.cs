using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKoloski_CompetencyExam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display thing

           
            int input = 0;
            do
            { 
                Console.WriteLine("****************************");
                Console.WriteLine("*** 1. Conditionals");
                Console.WriteLine("*** 2. For Loops");
                Console.WriteLine("*** 3. While Loops");
                Console.WriteLine("*** 4. Arrays");
                Console.WriteLine("*** 5. Lists");
                Console.WriteLine("*** -1 to exit program");
                Console.WriteLine("****************************");
                input = int.Parse(Console.ReadLine());

                // Conditionals
                if (input == 1)
                {
                    // Grade Level
                    int gradeLevel = 0;
                    int readingLevel = 0;

                    Console.WriteLine("Enter Your Grade.");
                    int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Your Reading Level");
                    int.Parse(Console.ReadLine());

                    if (gradeLevel == readingLevel)
                    {
                        Console.WriteLine("Congratulations, You read at an appropriate level");
                    }
                    else if (readingLevel != gradeLevel)
                    {
                        Console.WriteLine("You need to read more");
                    }
                }
                // For Loops
                else if (input == 2)
                {
                    // What to count to.
                    int count = 0;
                    //What to count by.
                    int countBy = 0;
                    Console.WriteLine("Enter a number to count to.");
                    int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter a number to count by.");
                    int.Parse(Console.ReadLine());


                }

                // While Loops
                else if (input == 3)
                {
                    // set variables
                    int count = 0;
                    int number = 0;


                    Console.WriteLine("Starts at 0, Enter Integer Values to add to, and print the sum. Enter 0 to stop adding");
                    // add until the number put in is 0
                    do
                    {
                        count = count + number;
                        Console.WriteLine("Enter a value: "+ number);
                        input = int.Parse(Console.ReadLine());

                        Console.WriteLine("The new sum is " + count + input);



                    } while (number != 0);

                }
                //Arrays
                else if (input == 4)
                {
                    int newint = 0;
                    int countarray[0,9];
                    Console.WriteLine

                }






            } while (input != -1);
        }
    }
}
