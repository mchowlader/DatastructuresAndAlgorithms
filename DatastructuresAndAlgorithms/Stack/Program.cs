using System;
using System.Collections;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stackD = new StackData(5);
            stackD.push(10);
            stackD.push(11);
            stackD.push(12);
            stackD.push(13);
            stackD.push(14);

            stackD.push(15);

            stackD.pop();
            stackD.pop();
            stackD.pop();
            stackD.pop();
            stackD.pop();

            stackD.pop();

            stackD.push(10);
            stackD.push(11);
            stackD.push(12);
            stackD.push(13);
            stackD.push(14);
        }
    }
}