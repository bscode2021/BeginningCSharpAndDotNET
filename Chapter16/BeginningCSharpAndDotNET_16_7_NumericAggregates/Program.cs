int[] numbers = GenerateLotsOfNumbers(12345678);
var queryResult = 
    from n in numbers
    where n > 1000
    select n;

Console.WriteLine("Count of numbers > 1000");
Console.WriteLine(queryResult.Count());
Console.WriteLine("Max of numbers > 1000");
Console.WriteLine(queryResult.Max());
Console.WriteLine("Min of numbers > 1000");
Console.WriteLine(queryResult.Min());
Console.WriteLine("Avrage of numbers > 1000");
Console.WriteLine(queryResult.Average());
Console.WriteLine("Sum of numbers > 1000");
Console.WriteLine(queryResult.Sum(n => (long)n));
Console.Write("Program finished, press Enter/Return to continue:");

int[] GenerateLotsOfNumbers(int count)
{
    Random generator = new Random(0);
    int[] result = new int[count];
    for (int i = 0; i < count; i++)
    {
        result[i] = generator.Next();
    }
    return result;
}