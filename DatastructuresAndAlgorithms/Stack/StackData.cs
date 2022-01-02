using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackData
    {

        int max;
        int item;
        int top = 0;
        int[] stackArray;

        public StackData(int size)
        {
            stackArray = new int[size];
            max = size;
        }

        public void push(int item)
        {
            if(top < max)
            {
                stackArray[top] = item;
                Console.WriteLine($"Push the item {stackArray[top]}");
                top++;
            }
            else
            {
                Console.WriteLine("Stack is full");
            }
        }

        public int pop()
        {
            if(top == 0)
            {
                Console.WriteLine("Stack is empty");
                return 0;
            }
            else
            {
                top--;
                item = stackArray[top];
                stackArray[top] = 0;
                Console.WriteLine($"Pop the item {item}");
                return item;
            }
        }
    }
}