using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_andAbstraction
{
   abstract class Motorcycle: Motorized_vehicle
    {
        protected string make;
        
        

        public Motorcycle(float weight, float height, bool isloud, bool isfast, string make, int numbofwheels)
            :base( height, weight, isfast, isloud, numbofwheels)
        {
            this.make = make;
            this.numbofwheels = numbofwheels;
           
        }
        public override void printcar()
        {
            Console.WriteLine("Weight" + weight + "Height:" + height + "Is loud" + isloud + "is fast" + isfast + " make:" + make + "horse power:" + "number of wheels" + numbofwheels);
        }
    }
}
