int number = int.Parse(Console.ReadLine());

string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

if (number > 7 || number == 0)
{
    Console.WriteLine("Invalid day!");
}
else
{
    Console.WriteLine(days[number - 1]);
}

string input = Console.ReadLine();

string[] words = input.Split(" ").ToArray();
int count = 0;

foreach (string word in words)
{
    Console.Write(word + " ");
    count++;
}
Console.WriteLine();
Console.WriteLine(count);

