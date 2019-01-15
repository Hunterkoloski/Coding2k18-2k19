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
        protected float thrust;
        protected float torqe;

        public Motorcycle(float weight, float height, bool isloud, bool isfast, string make, float torqe, float thrust)
            :base(weight, height, isloud, isfast)
        {
            this.make = make;
            this.thrust = thrust;
            this.torqe = torqe;
        }
    }
}
