using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Character_Creator
{
    class Program
    {
        static void Main(string[] args)
        {
            int uinput;
            Character user = new Character(" ", 0, 0, 0, 0, 0);
            String path = AppDomain.CurrentDomain.BaseDirectory + user.name + ".txt";
            Console.WriteLine("Welcome to my character modifier program!");

            do
            {
                Console.WriteLine("Press a number based on the action that you want to perform:");
                Console.WriteLine("1. Create a character");
                Console.WriteLine("2. Modify a character");
                Console.WriteLine("3. Delete a character");
                Console.WriteLine("4. Load all existing characters");
                Console.WriteLine("5. List all current characters");
                Console.WriteLine("6. Quit");
                Console.WriteLine();

                uinput = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (uinput == 1)
                {
                    user = CreateCharacter();
                }

                if (uinput == 2)
                {

                }

                if (uinput == 3)
                {

                }

                if (uinput == 4)
                {

                }

                if (uinput == 5)
                {

                }
            }
            while (uinput != 6);
        }

        static Character CreateCharacter()
        {
            string name;
            int amountofsupremegear;
            int height;
            int weight;
            int shoesize;
            int strength;

            Console.WriteLine("What is your characters name?");
            name = Console.ReadLine();
            Console.WriteLine("How fat is your character?");
            weight = int.Parse(Console.ReadLine());
            Console.WriteLine("How tall is your character?");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your character's Shoe Size?");
            shoesize = int.Parse(Console.ReadLine());
            Console.WriteLine("How strong is your character?");
            strength = int.Parse(Console.ReadLine());
            Console.WriteLine("How Much supreme gear does your charracter own?");
            amountofsupremegear = int.Parse(Console.ReadLine());

            Character user = new Character(name, amountofsupremegear, strength, height, shoesize, weight);
            return user;
        }
        static void ModifyCharacter(Character character)
        {

        }
        static void SaveCharacter(Character character)
        {
            String path = AppDomain.CurrentDomain.BaseDirectory + character.name + ".txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File exists would you like to erase it?");
                if (Console.ReadLine()[0] == 'y')
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(character.name);
                        sw.WriteLine(character.weight);
                        sw.WriteLine(character.height);
                        sw.WriteLine(character.shoesize);
                        sw.WriteLine(character.strength);
                        sw.WriteLine(character.amountofsupremegear);
                    }
                    Console.WriteLine("File Overwritten");
                }

                else
                {
                    Console.WriteLine("Nothing was overwritten");
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(character.name);
                    sw.WriteLine(character.weight);
                    sw.WriteLine(character.height);
                    sw.WriteLine(character.shoesize);
                    sw.WriteLine(character.strength);
                    sw.WriteLine(character.amountofsupremegear);
                }
                Console.WriteLine("File created");
            }
        }
    }
}



