List<int> commands = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
Stack<int> output = new Stack<int>();
int N = commands[0];
int S = commands[1];
int X = commands[2];
for (int i = 0; i < N; i++)
{
    int n = int.Parse(Console.ReadLine());
    output.Push(n);
}

for (int i = 0; i < S; i++)
{
    output.Pop();
}
if (output.Contains(X))
{
    Console.WriteLine(true);
}
else
{
    int min = int.MaxValue;
    foreach (var item in output)
    {     
        if (item<min)
        {
            min = item;
        }
    }
    Console.WriteLine(min);
}
