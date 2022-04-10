using System;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new CircularQueue(5);

            queue.Enqueue(1);
        }
    }
}
