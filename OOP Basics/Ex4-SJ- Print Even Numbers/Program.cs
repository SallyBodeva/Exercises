using System.Collections.Generic;

int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
Queue<int> output = new Queue<int>();
foreach (var item in input)
{
    if (item%2==0)
    {
        output.Enqueue(item);
    }
}
Console.WriteLine(String.Join(", ",output));