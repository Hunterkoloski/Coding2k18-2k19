using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static Random rand = new Random(1234);
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();
            for (int i = 0; i < 1000; i++)
                integers.Add(rand.Next(0, 1000));
            integers.Sort();
            bool result = searchIntlist(integers, 0);
        }

    }
}
