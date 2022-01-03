using System;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 1, 5, 8, 7, 10 };
            Console.Write("Enter your target item - ");
            var item = int.Parse(Console.ReadLine());

            var start = 0;
            var end = data.Length-1;
            int mid;

            while (start <= end)
            {
                mid = start+end/2;
                if(data[mid] == item)
                {
                    Console.WriteLine(data[mid]);
                }
                if(item < data[mid])
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