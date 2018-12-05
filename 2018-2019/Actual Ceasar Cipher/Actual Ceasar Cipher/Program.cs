using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actual_Ceasar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString;
            int userChar;
            int shiftvalue;
            List<char> MyList = new List<char> { };

            char newChar;
            Console.WriteLine("Enter in your phrase");
            userString = Console.ReadLine();
            Console.WriteLine("Enter your shift value, between -25 and +25.");
            shiftvalue = int.Parse(Console.ReadLine());
            for (int i = 0; i < userString.Length; i++)
            {
                userChar = userString[i];
                if (userChar >= 65 && userChar <= 90)
                {
                    int uppercase;
                    uppercase = userChar;
                    uppercase += shiftvalue;
                    if (uppercase > 90)
                    {

                    }
                }

                userChar += shiftvalue;
                if (userChar > 122)
                {
                    userChar = 97 + shiftvalue;
                }
                else if (userChar < 97)

                {
                    userChar = 122 + shiftvalue;
                }


                newChar = (char)userChar;
                MyList.Add(newChar);

            }
            for (int i = 0; i < userString.Length; i++)
            {
                Console.Write(MyList[i]);

            }
            Console.ReadKey();
            return;


        }


    }
}