Queue<string> customers = new Queue<string>();
Queue<string> output = new Queue<string>();

while (true)
{
    string cmd = Console.ReadLine();
    if (cmd != "Paid")
    {
        customers.Enqueue(cmd);
    }
    if (cmd=="Paid")
    {
        foreach (var item in customers)
        {
            output.Enqueue(item);
        }
        customers.Clear();
    }
    if (cmd=="End")
    {
        foreach (var item in output)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"{customers.Count-1} people remaining");
    }
}