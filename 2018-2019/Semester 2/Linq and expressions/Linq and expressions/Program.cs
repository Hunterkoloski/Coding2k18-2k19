using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_and_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> l1 = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            //List<int> l2 = new List<int>() { 3, 2, 2, 8, 0, 4, 7 };
            //List<int> l3 = l1.Intersect(l2).ToList();
            //for (int i = 0; i < l3.Count; i++)
            //{
            //    Console.WriteLine(l3[i]);
            //}
            //Console.ReadLine();
            List<int> l1 = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            List<int> l2 = l1.Where(t => t >= 5).ToList();
            for (int i = 0; i < l2.Count; i++)
            {
                Console.WriteLine(l2[i]);
            }
            Console.ReadLine();
        }
    }
}
