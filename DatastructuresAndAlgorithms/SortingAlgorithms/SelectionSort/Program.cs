using System;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a array size: ");
            var size = int.Parse(Console.ReadLine());
            int[] values = new int[size];

            for (int i = 0; i < values.Length; i++)
            {
                Console.Write($"Enter the array item[{i}]: ");
                values[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < values.Length; i++)
            {
                var min = i;

                for (int j = i+1; j < values.Length; j++)
                {
                    if(values[min] > values[j])
                    {
                        min = j;
                    }
                }

                if(values[min] != values[i])
                {
                    var temp = values[min];
                    values[min] = values[i];
                    values[i] = temp;
                }
            }

            Console.Write("Here is the sorting array: ");
            Console.Write("[ ");

            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i] + " ");
            }

            Console.Write("]");
        }
    }
}
