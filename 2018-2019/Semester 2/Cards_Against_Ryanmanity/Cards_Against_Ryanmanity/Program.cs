using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cards_Against_Ryanmanity.Classes;
namespace Cards_Against_Ryanmanity
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            Decks mydeck = new Decks();
            Cards mycard = new Cards("","");

            while (option != 6)
            {
                Console.WriteLine("Option one Shuffle");
                Console.WriteLine("Option two print deck");
                Console.WriteLine("Option three draw card");
                Console.WriteLine("Option four print discard pile");
                Console.WriteLine("Option five discard");
                Console.WriteLine("Option six exit program");
                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    
                    mydeck.shuffle();
                }
                if (option == 2)
                {
                   
                    mydeck.Printdecks();
                }
                if (option == 3)
                {
                    mycard = mydeck.Draw();
                }
                if (option == 4)
                {
                    mydeck.Printdiscard();
                }
                if (option == 5)
                {
                    mydeck.Discard(mycard);
                }
            }
        }

    }
}
