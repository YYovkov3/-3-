using System.IO.Pipes;

Queue<int> queue = new();
int[] numbersOperations = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int numbersToPush = numbersOperations[0];
int numbersToPop = numbersOperations[1];
int number = numbersOperations[2];
for (int i = 0; i < numbersToPush; i++)
{
    queue.Enqueue(numbers[i]);
}
for (int i = 0; i < numbersToPop; i++)
{
    queue.Dequeue();
}
if (queue.Contains(number))
{
    Console.WriteLine("true");
}
else
{
    if (queue.Any())
    {
        Console.WriteLine(queue.Min());
    }
    else
    {
        Console.WriteLine(0);
    }
}
