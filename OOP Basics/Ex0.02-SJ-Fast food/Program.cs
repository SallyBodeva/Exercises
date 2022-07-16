int quantityFood = int.Parse(Console.ReadLine());
List<int> ints = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
Queue<int> Orders = new Queue<int>();
Queue<int> leftOrders = new Queue<int>();

foreach (var item in ints)
{
    Orders.Enqueue(item);
}
int max = int.MinValue;
foreach (var item in Orders)
{
    if (item>max)
    {
        max = item;
    }
}
Console.WriteLine(max);
foreach (var item in Orders)
{
    if (item<quantityFood)
    {
        Orders.Dequeue();
        quantityFood -= item;
    }
    else
    {
        leftOrders.Enqueue(item);
    }
}
if (quantityFood>=0)
{
    Console.WriteLine($"Orders complete");
}
else
{
    foreach (var item in leftOrders)
    {
        Console.WriteLine($"Orders left: {item}");
    }
}

