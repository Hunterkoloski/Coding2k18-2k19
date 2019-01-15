using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_andAbstraction
{
    abstract class Motorized_vehicle
    {
        public float height;
        public float weight;
        public bool isfast;
        public bool isloud;
        public Motorized_vehicle(float height, float weight, bool isfast, bool isloud)
        {
            this.height = height;
            this.weight = weight;
            this.isfast = isfast;
            this.isloud = isloud;
        }
    }
}
