using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKoloski_Hangman
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] WordList = new string[25];
            WordList[0] = "Peck";
            WordList[1] = "Makeshift";
            WordList[2] = "Sand";
            WordList[3] = "Tranquil";
            WordList[4] = "Drag";
            WordList[5] = "Circle";
            WordList[6] = "Curve";
            WordList[7] = "Jam";
            WordList[8] = "Groovy";
            WordList[9] = "Insect";
            WordList[10] = "Fair";
            WordList[11] = "Opposite";
            WordList[12] = "Station";
            WordList[13] = "Amazing";
            WordList[14] = "Unkempt";
            WordList[15] = "Church";
            WordList[16] = "Ruthless";
            WordList[17] = "Consist";
            WordList[18] = "Mundane";
            WordList[19] = "Milky";
            WordList[20] = "Sweltering";
            WordList[21] = "Damp";
            WordList[22] = "Rabid";
            WordList[23] = "Swanky";
            WordList[24] = "Mint";

            int turn = 0;

            // Choose a random word
            Random rand = new Random();

            int i = rand.Next(0, 25);
            string magicWord = WordList[i];
            Console.WriteLine(magicWord + i);

            List<char> guesses = new List<char>();
            bool isvalid = true;
            // Loop until count is 6 or word is guessed
            do
            {
                 isvalid = true;
                // Guess the Random word

                // letter from user
                Console.WriteLine();
                Console.WriteLine("Enter a Letter");
                char letter = char.Parse(Console.ReadLine());
                if (magicWord.Contains(letter) == false)
                {
                    turn += 1;
                }
                guesses.Add(letter);
                // Check for Letter in the word
                for (int j = 0; j < magicWord.Length; j++)
                {
                    if (guesses.Contains(magicWord[j]))

                    {
                        Console.Write(" " + magicWord[j]);
                    }
                    else
                    {
                        Console.Write("_");
                        isvalid = false;
                    }
                    
                }
                if (isvalid == true)
              
                    break;


            } while (turn <= 6);
            Console.WriteLine();

            if (isvalid == true)
            {
                Console.Write("You win");
            }

            if ( turn > 6 )
            {
                Console.Write("You lost the word was " + magicWord);
            }
            Console.WriteLine();
            // Print Letter in proper position
            // if not tell user
        }
    }
}
