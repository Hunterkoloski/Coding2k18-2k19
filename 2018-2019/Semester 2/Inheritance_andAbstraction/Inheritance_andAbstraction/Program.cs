using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_andAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Motorized_vehicle> motor_vehicle = new List<Motorized_vehicle>();
            motor_vehicle.Add(new sportscar(3142f, 50.6f, true, true, 183f, 580f, Porsche, "porsche 911", 4));
        }
    }
}
