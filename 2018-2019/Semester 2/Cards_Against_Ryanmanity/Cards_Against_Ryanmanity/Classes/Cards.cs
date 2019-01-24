using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards_Against_Ryanmanity.Classes
{
    class Cards
    {
        public string suit = "";
        public string face = "";
       public Cards(string suit, string face)
        {
            this.suit = suit;
            this.face = face;
        }
        public void print()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~\n " + suit + " of " + face + "\n~~~~~~~~~~~~~~~~~~~~~~~~");
        }

    }
}
