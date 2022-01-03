using System;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 1, 5, 7, 8, 10 };
            Console.Write("Enter your target item - ");
            var item = int.Parse(Console.ReadLine());

            var start = 0;
            var end = data.Length - 1;
            var mid = start + end / 2;

            while (start <= end)
            {
                if(mid >= data.Length)
                {
                    Console.WriteLine($"Item {item} could not found in the list.");
                    break;
                }

                if (data[mid] == item)
                {
                    Console.WriteLine($"The target value {data[mid]} is found at position {mid + 1}");
                    break;
                }

                if (item < data[mid])
                {
                    mid = mid - 1;

                }
                else
                {
                    mid = mid + 1;
                }
            }
        }
    }
}