using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static bool CheckForPrime(int n, int divisor = 2)
        {
            if(n%divisor == 0)
            {
                return false;
            }
            if(divisor == (n - 1))
            {
                return true;
            }
            else
            {
                return CheckForPrime(n, divisor + 1);
            }
        }
    }
}
