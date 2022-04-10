using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class CircularQueue
    {
        private int[] Elements;
        private int Head;
        private int Tail;
        private int Max;
        private int Count;

        public CircularQueue(int size)
        {
            Elements = new int[size];
            Max = size;
            Head = 0;
            Tail = -1;
            Count = 0;
        }

        public void Enqueue(int item)
        {
            if (Count == Max)
            {
                Console.WriteLine("Queue overflow");
            }
            else
            {
                Tail = (Head + 1) % Max; 1%5
                var x = (Head + 1) / Max;
                Elements[Head] = item;
                Count++;
            }
        }

    }
}
