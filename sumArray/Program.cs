int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int sum = 0;

foreach (int i in numbers)
{
    sum += numbers[i];
}

Console.WriteLine(sum);