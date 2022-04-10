using System;

namespace InsertionSort
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

            for (int i = 1; i < values.Length; i++)
            {
                var temp = values[i];
                var j = i - 1;

                while(j >= 0 && temp < values[j])
                {
                    values[j+1] = values[j];
                    j--;
                }

                values[j+1] = temp;
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


//Best case insertion sort:
//-Time: O(n)
//-Space: O(n)

//Worse case insertion sort:
//-Time: O(n^2)
//-Space: O(n^2)