using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_andAbstraction
{
    abstract class Car: Motorized_vehicle   
    {
        protected int numbofwheels = 0;
        protected string cartype;
        protected string carengine;

        public Car( string cartype, int numbofwheels, string carengine, float height, float weight, bool isfast, bool isloud, string make)
               :base(height, weight, isfast, isloud)
        {
            this.numbofwheels = numbofwheels;
            this.carengine = carengine;
            this.cartype = cartype;



        }
    }
}
