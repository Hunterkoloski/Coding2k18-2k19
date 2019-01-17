using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_andAbstraction
{
    abstract class Car: Motorized_vehicle   
    {
        
        protected string cartype;

        public Car(float weight, float height, int numbofwheels, string make, string cartype, bool isfast, bool isloud)
               :base( height, weight, isfast, isloud, numbofwheels,make  )
        {
            this.cartype = cartype;



        }

    }
}
