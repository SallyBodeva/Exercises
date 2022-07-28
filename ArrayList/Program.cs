MyArrayList<int> test = new MyArrayList<int>();

test.Add(7);
test.Add(11);
test.Add(28);
test.Add(14);
test.Add(13);
Console.WriteLine(String.Join(" ",test));
test.RemoveAt(2);

Console.WriteLine(String.Join(" ", test));

test.Get(0);
