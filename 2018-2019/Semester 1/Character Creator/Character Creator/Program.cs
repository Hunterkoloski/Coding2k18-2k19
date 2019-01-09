using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace awinsor_CharacterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu_chc = 0;

            Character currCharacter = new Character("", 8, 8, "", "");


            while (menu_chc != 6)

            {


                Console.WriteLine("***********************");
                Console.WriteLine("1 - Create a Character");
                Console.WriteLine("2 - Modify a Character");
                Console.WriteLine("3 - Delete a Character");
                Console.WriteLine("4 - Load a Character");
                Console.WriteLine("5 - Print a Character");
                Console.WriteLine("6 - EXIT");
                Console.WriteLine("***********************");


                Console.Write("\nPlease choose an option from the menu above: ");
                menu_chc = int.Parse(Console.ReadLine());

                switch (menu_chc)
                {
                    case 1:

                        currCharacter = CreateCharacter();

                        break;

                    case 2:

                        ModifyCharacter(currCharacter);

                        break;

                    case 3:

                        Console.WriteLine("Please choose a character name to delete their file: ");
                        DeleteCharacter(Console.ReadLine());

                        break;

                    case 4:

                        Console.WriteLine("\nPlease enter characters name that you want to load:");
                        currCharacter = LoadCharacter(Console.ReadLine());

                        Console.ReadLine();

                        break;

                    case 5:

                        PrintCharacter(currCharacter);

                        break;

                }

            }





        }

        public static Character CreateCharacter()
        {
            string name = "";
            int height = 0;
            int age = 0;
            string skin_color = "";
            string hair_color = "";

            Console.Write("\nPlease choose a name for your character: ");
            name = Console.ReadLine();

            Console.Write("\n\nPlease choose a height for your character: ");
            height = int.Parse(Console.ReadLine());

            Console.Write("\n\nPlease choose a age for your character: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("\n\nPlease choose a skin color for your character: ");
            skin_color = Console.ReadLine();

            Console.Write("\n\nPlease choose a hair color for your character: ");
            hair_color = Console.ReadLine();

            Character mycharacter = new Character(name, height, age, skin_color, hair_color);
            SaveCharacter(mycharacter);

            return mycharacter;

        }

        static void SaveCharacter(Character character)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + character.name + ".txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File exists, would you like to overwrite? y, n");
                if (Console.ReadLine()[0] == 'y')
                {

                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(character.name);
                        sw.WriteLine(character.height);
                        sw.WriteLine(character.age);
                        sw.WriteLine(character.skin_color);
                        sw.WriteLine(character.hair_color);
                    }
                    Console.WriteLine("File overwritten");

                }
                else
                {
                    Console.WriteLine("Nothing overwritten");
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(character.name);
                    sw.WriteLine(character.height);
                    sw.WriteLine(character.age);
                    sw.WriteLine(character.skin_color);
                    sw.WriteLine(character.hair_color);
                }
                Console.WriteLine("File created");
            }
        }

        static void ModifyCharacter(Character character)
        {
            int changewhat = 0;


            while (changewhat != 5)
            {
                Console.Clear();

                Console.WriteLine("***********************");
                Console.WriteLine("1 - Modify Height");
                Console.WriteLine("2 - Modify Age");
                Console.WriteLine("3 - Modify Skin Color");
                Console.WriteLine("4 - Modify Hair Color");
                Console.WriteLine("5 - EXIT");
                Console.WriteLine("***********************");


                Console.Write("\nPlease choose an option from the menu above: ");
                changewhat = int.Parse(Console.ReadLine());


                switch (changewhat)
                {
                    case 1:

                        Console.WriteLine("\nWhat height would you like " + character.name + "?: ");
                        character.height = int.Parse(Console.ReadLine());
                        break;

                    case 2:

                        Console.WriteLine("\nWhat age would you like " + character.name + " ?: ");
                        character.age = int.Parse(Console.ReadLine());

                        break;

                    case 3:

                        Console.WriteLine("\nWhat skin color would you like " + character.name + "to have?: ");
                        character.skin_color = Console.ReadLine();

                        break;

                    case 4:

                        Console.WriteLine("\nWhat hair color would you like " + character.name + " to have?: ");
                        character.hair_color = Console.ReadLine();

                        break;
                }

            }


            SaveCharacter(character);


        }

        static bool DeleteCharacter(string characterName)
        {
            bool tf = false;
            string path = AppDomain.CurrentDomain.BaseDirectory + characterName + ".txt";

            if (File.Exists(path))
            {
                File.Delete(path);
                tf = true;
            }

            else
            {
                tf = false;
            }

            return tf;
        }

        static Character LoadCharacter(string characterName)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + characterName + ".txt";

            Character character;

            List<string> file = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                character = new Character(sr.ReadLine(), int.Parse(sr.ReadLine()), int.Parse(sr.ReadLine()), sr.ReadLine(), sr.ReadLine());
            }

            return character;
        }

        static void PrintCharacter(Character character)
        {
            Console.Write("\n\nName: " + character.name + "\nHeight: " + character.height + "\nAge: " + character.age + "\nSkin Color: " + character.skin_color + "\nHair Color: " + character.hair_color);
        }
    }
}

