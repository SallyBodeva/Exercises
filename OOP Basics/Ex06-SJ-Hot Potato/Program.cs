int n = int.Parse(Console.ReadLine());
Queue<string> cars = new Queue<string>();
Queue<string> carsOutput = new Queue<string>();
while (true)
{
    string cmd = Console.ReadLine();
    if (cmd == "green")
    {
        foreach (var item in cars)
        {
            if (!carsOutput.Contains(item))
            {
                carsOutput.Enqueue(item);
            }           
        }
    }
    cars.Enqueue(cmd);
    if (cmd=="end")
    {
        foreach (var item in carsOutput)
        {
            Console.WriteLine($"{item} passed!");
        }
        Console.WriteLine($"{carsOutput.Count} cars passed the crossroads.");
        break;
    }
}
