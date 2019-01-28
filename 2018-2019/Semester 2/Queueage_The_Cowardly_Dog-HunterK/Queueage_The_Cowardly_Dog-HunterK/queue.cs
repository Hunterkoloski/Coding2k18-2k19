using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queueage_The_Cowardly_Dog_HunterK
{
    class queue
    {
        List<int> holder = new List<int>();

     

        
        //push
        public void enqueue(int val)
        {

            holder.Add(val);

        }
        //pop
        public int dequeue()
        {
            if (holder.Count > 1)
            {


                int Boolin = holder[0];
                holder.RemoveAt(0);
                return Boolin;
            }
            else
                return 000;
        }
        //peek
        public int Peek()
        {
            if (holder.Count > 1)
            {
                int Boolin = holder[0];
                return Boolin;
            }
            else
                return 000;
        }
        //print
        public void Print()
        {
            for (int i = 0; i < holder.Count - 1; i++)
            {
                Console.WriteLine(holder[i]);
            }

        }
    }


}

