









using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Creator
{
    class Character
    {
       public string name;
       public int amountofsupremegear;
       public int strength;
       public int height;
       public int shoesize;
       public int weight;

        public Character(string name, int amountofsupremegear, int strength, int height, int shoesize, int weight)
        {
            this.name = name;
            this.amountofsupremegear = amountofsupremegear;
            this.strength = strength;
            this.weight = weight;
            this.shoesize = shoesize;
            this.weight = weight;

        }
        
    }
}
