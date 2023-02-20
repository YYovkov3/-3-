using System.IO.Pipes;

Stack<int> stack = new();
int[] numbersOperations = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int[] numbers = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int numbersToPush = numbersOperations[0];
int numbersToPop = numbersOperations[1];
int number = numbersOperations[2];
for (int i = 0;i < numbersToPush; i++)
{
    stack.Push(numbers[i]);
}
for (int i = 0;i < numbersToPop; i++)
{
    stack.Pop();
}
if(stack.Contains(number))
{
    Console.WriteLine("true");
}
else
{
    if(stack.Any())
    {
        Console.WriteLine(stack.Min());
    }
    else
    {
        Console.WriteLine(0);
    }
}
