using System;

namespace BuzzerGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] participent = new int[10];
            for (int i = 0; i < participent.Length; i++) participent[i] = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Gamer Id: ");
                var id = int.Parse(Console.ReadLine());
                participent[id - 1]++;
            }

            var maxPoint = 0;
            for (int i = 0; i < participent.Length; i++)
            {
                if (participent[i] > maxPoint)
                {
                    maxPoint = participent[i];
                }
            }

            for (int i = 0; i < participent.Length; i++)
            {
                if(maxPoint == participent[i])
                {
                    Console.WriteLine($"Gamer Id: {i+1}");
                    break;
                }
            }
        }
    }
}
