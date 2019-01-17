using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_andAbstraction
{
    class Cruiser_motorcycle : Motorcycle
    {
        public Cruiser_motorcycle(int weight, int height, int numbofwheels, string make, bool isloud, bool isfast)
            :base( height, weight, isloud, isfast, make, numbofwheels)
        {

        }
        public override void printcar()
        {
            Console.WriteLine( "\nHeight " + height+ "\nWeight " + weight+ "\nNumbofwheels " + numbofwheels + "\nMake" + make + "\nIsloud" + isloud + "\nIsfast" + isfast);
        }
    }
}
