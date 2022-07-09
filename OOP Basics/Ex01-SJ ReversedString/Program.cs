using System.Collections.Generic;

string word = Console.ReadLine();
Stack<char> revefrsing = new Stack<char>();
foreach (var item in word)
{
    revefrsing.Push(item);
}
Console.WriteLine(string.Join("",revefrsing));