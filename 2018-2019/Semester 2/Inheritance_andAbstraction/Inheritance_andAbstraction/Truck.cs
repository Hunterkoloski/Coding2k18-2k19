using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_andAbstraction
{
    abstract class Truck: Motorized_vehicle
    {
        protected float towingcapacity;
        protected bool isheavy;
        protected float horsepower;
        public Truck(float weight, float height, bool isloud, bool isfast, float towingcapacity,  float horsepower, int numbofwheels)
          : base(  height, weight, isfast, isloud, numbofwheels)
        {
            this.towingcapacity = towingcapacity;
            this.horsepower = horsepower;
        }
        public override void printcar()
        {
            Console.WriteLine("Weight" + weight + "Height:" + height + "Is loud" + isloud + "is fast" + isfast + "towing capacity" + towingcapacity+ "horse power:" + horsepower  + "number of wheels" + numbofwheels);
        }
    }
}
