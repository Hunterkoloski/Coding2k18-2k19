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
        public Truck(float weight, float height, bool isloud, bool isfast, float towingcapacity, bool isheavy, float horsepower)
          : base(weight, height, isloud, isfast)
        {
            this.towingcapacity = towingcapacity;
            this.isheavy = isheavy;
            this.horsepower = horsepower;
        }
    }
}
