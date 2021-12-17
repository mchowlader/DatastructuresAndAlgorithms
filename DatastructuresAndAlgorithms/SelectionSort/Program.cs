internal class Program
{
    static void Main(string[] args)
    {
        int[] selectionArray = new int[] { 10, 5, 6, 12, 3 };
        var count = 0;

        for (int i = 0; i < selectionArray.Length-1; i++)
        {
            var minValue = i;

            for (int j = i+1; j < selectionArray.Length; j++)
            {
                count++;
                if (selectionArray[minValue] > selectionArray[j])
                {
                    minValue = j;
                }
            }

            if(minValue != i)
            {
                var temp = selectionArray[i];
                selectionArray[i] = selectionArray[minValue];
                selectionArray[minValue] = temp;
            }
        }

        for (int i = 0;i < selectionArray.Length; i++)
        {
            Console.Write($" {selectionArray[i]}");
        }
     
        Console.WriteLine();
        Console.WriteLine($"Total loop cycle count {count} times.");
    }
}