
List<int> inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


Stack<int> ints = new Stack<int>();
foreach (var item in inputs)
{
    ints.Push(item);
}
while (true)
{
    List<string> cmd = Console.ReadLine().ToLower().Split(' ').ToList();
    if (cmd[0]=="add")
    {
        int a = int.Parse(cmd[1]);
        int b = int.Parse(cmd[2]); 
        ints.Push(a);
        ints.Push(b);
    }
    if (cmd[0] == "remove")
    {
        int r = int.Parse(cmd[1]);
        if (ints.Count>=r)
        {
            for (int i = 0; i < r; i++)
            {
                ints.Pop();
            }
        }
    }
    if (cmd[0] == "end")
    {
        int sum = ints.Sum();
        Console.WriteLine($"Sum:{sum}");
        break;
    }
}
