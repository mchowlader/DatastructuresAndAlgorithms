using System;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] insertionArray = new int[] { 10, 5, 6, 12, 3 };

            for (int i = 1; i < insertionArray.Length; i++)
            {
                var item = insertionArray[i];
                var j = i - 1;

                while(j >= 0 && insertionArray[j] > item)
                {
                    insertionArray[j + 1] = insertionArray[j];
                    j = j - 1;
                }

                insertionArray[j+1] = item;
            }

            for (int i = 0; i < insertionArray.Length; i++)
            {
                Console.Write($" {insertionArray[i]}");
            }
        }
    }
}