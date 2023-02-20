Stack<int> stackNumbers = new();
int queries = int.Parse(Console.ReadLine());
for(int i = 0;i < queries; i++)
{
    int[] numTypers = Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    int command = numTypers[0];
    if(command==1)
    {
        int element = numTypers[1];
        stackNumbers.Push(element);
    }
    else if(command==2)
    {
        stackNumbers.Pop();
    }
    else if(command==3)
    {
        if(stackNumbers.Any())
        {
            Console.WriteLine(stackNumbers.Max());
        }     
    }
    else if(command==4)
    {
        if(stackNumbers.Any() )
        {
            Console.WriteLine(stackNumbers.Min());
        }
    }
}
Console.WriteLine(string.Join(", ", stackNumbers));