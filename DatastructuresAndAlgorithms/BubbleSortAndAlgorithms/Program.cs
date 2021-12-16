internal class Program
{
    static void Main(string[] args)
    {
        int[] bubbleArray = new int[] { 10, 5, 6, 12, 3 };
        var Count = 0;
        for (int i = 0; i < bubbleArray.Length; i++)
        {
            for (int j = 0; j < bubbleArray.Length -i- 1; j++)
            {
                Count++;
                if (bubbleArray[j] > bubbleArray[j + 1])
                {
                    var temp = bubbleArray[j];
                    bubbleArray[j] = bubbleArray[j + 1];
                    bubbleArray[j + 1] = temp;
                }
            }
        }

        for (int i = 0; i < bubbleArray.Length; i++)
        {
            Console.Write($" {bubbleArray[i]}");
        }

        Console.WriteLine();
        Console.WriteLine($"Total loop cycle count {Count} times.");
    }
}