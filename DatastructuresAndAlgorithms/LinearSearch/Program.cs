using System;

namespace LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] linearList = new int[] {5,4,3,2,1};
            Console.Write("Enter your searching Intem - ");
            var item = int.Parse(Console.ReadLine());
            var result = linearSearch(linearList, item);

            if (result != -1)
            {
                Console.WriteLine($"The target value {item} is found at position {i + 1}");
            }
            else
                Console.WriteLine("Target not found");

            int linearSearch(int[] linearList, int item)
            {
                
                for ( i = 0; i < linearList.Length-1; i++)
                {
                    if (linearList[i] == item)
                    {
                        return i;
                    }
                }

                i = -1;
                return i;
            }
        }
    }
}