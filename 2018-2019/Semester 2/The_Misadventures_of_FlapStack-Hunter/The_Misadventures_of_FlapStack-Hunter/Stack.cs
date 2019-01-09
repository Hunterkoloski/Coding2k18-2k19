using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Misadventures_of_FlapStack_Hunter
{
    class Stack
    {
        List<int> holder = new List<int>();
        
        public Stack()
        {

        }
        //push
        public void Push(int val)
        {
           
            holder.Add(val);

        }
        //pop
        public int Pop()
        {
            if (holder.Count > 1)
            {


                int Boolin = holder[holder.Count - 1];
                holder.RemoveAt(holder.Count - 1);
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
                int Boolin = holder[holder.Count - 1];
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

