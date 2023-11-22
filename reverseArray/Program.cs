int number = int.Parse(Console.ReadLine());
int[] numbersSum = new int[number];

for (int i = 0; i < number; i++)
{
    int input = int.Parse(Console.ReadLine());

    numbersSum[i] = input;
}

for  (int i = number - 1 ; i >= 0; i--)
{
    Console.Write(numbersSum[i] + " ");
}