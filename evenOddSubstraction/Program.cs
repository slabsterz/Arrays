int[] inputNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int evenSum  = 0;
int oddSum  = 0;

foreach (int number in inputNumbers)
{
    if (number % 2 == 0)
    {
        evenSum += number;
    }
    else
    {
        oddSum += number;
    }
}
Console.WriteLine(evenSum-oddSum);