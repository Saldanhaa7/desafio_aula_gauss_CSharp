
using System;
using System.Runtime.Serialization;
List<int> valores = new List<int>();
for (var i = 100; i != 0; i--)
{
    var n = i % 5;
    if (n == 0)
    {
        var nome = "bruno";
        Console.Write($"{nome}, ");

    }
    else
        if (i == 1)
        {
        Console.Write($"{i}");
        }
        else
        {
        Console.Write($"{i}, ");
        }
    var par = i % 2;
    if (par == 0)
        {
        valores.Insert(0, i);
    }
}
Console.Write($"\r\n{valores.Sum()}");