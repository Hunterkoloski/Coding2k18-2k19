using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Queue<T>
    {
        List<T> queue = new List<T>();

        static int timesEnqueued = 0;
        static int timesDequeued = 0;
        static int maxAmount = 0;

        /// <summary>
        /// Default constructor to create a queue class
        /// </summary>
        public Queue()
        {

        }

        public int Count { get { return queue.Count; } }

        /// <summary>
        /// Enqueues a new board to the back of the queue.
        /// </summary>
        /// <param name="value">The board to add</param>
        public void Enqueue(T value)
        {
            queue.Add(value);
            timesEnqueued++;
            if (maxAmount < queue.Count)
                maxAmount = queue.Count;
        }

        /// <summary>
        /// Takes the front element of the queue and returns it. Removes it from the queue
        /// </summary>
        /// <returns>The removed board</returns>
        public T Dequeue()
        {
            timesDequeued++;
            T retVal = queue[queue.Count - 1];
            queue.RemoveAt(queue.Count - 1);
            return retVal;
        }

        /// <summary>
        /// Peeks at the front of the queue without removing it.
        /// </summary>
        /// <returns>The board at the front of the queue</returns>
        public T Peek()
        {
            return queue[queue.Count - 1];
        }
    }
}

