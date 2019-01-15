using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_andAbstraction
{
    abstract class sportscar: Car
    {
        protected float topspeed;
        protected float horsepower;
        
        
        public sportscar(float weight, float height, bool isloud, bool isfast, float topspeed, float horsepower)
            :base(cartype, numbofwheels, carengine, weight, height, isloud, isfast)
        {

        }
}
