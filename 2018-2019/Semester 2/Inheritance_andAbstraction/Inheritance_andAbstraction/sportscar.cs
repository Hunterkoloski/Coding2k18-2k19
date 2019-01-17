using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_andAbstraction
{
    abstract class sportscar : Car
    {
        protected float topspeed;
        protected float horsepower;
        


        public sportscar(float weight, float height, bool isloud, bool isfast, float topspeed, float horsepower, string cartype, int numbofwheels)
            : base(height, weight, numbofwheels, cartype, make, isfast, isloud)
        {
            this.topspeed = topspeed;
            this.horsepower = horsepower;
            
        }
        public override void printcar()
        {
            Console.WriteLine("Weight" + weight + "Height:" + height + "Is loud" + isloud + "is fast" + isfast + " topspeed:" + topspeed + "horse power:" + horsepower +  "car type:" + cartype + "make:" + make + "number of wheels" + numbofwheels);
        }
    }
}
