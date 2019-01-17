using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_andAbstraction
{
    class sedan : Car
    {
        public sedan(int weight, int height, int numbofwheels, string make,  string cartype, bool isfast, bool isloud)
            :base( weight, height, numbofwheels,  cartype, make, isfast, isloud)
        {

        }
        public override void printcar()
        {
            Console.WriteLine("\nWeight " + weight + "\nHeight " + height + "\nNumbofwheels " + numbofwheels +   "car type" + cartype + "isfast" + isfast);
        }
    }
}
