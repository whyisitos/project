using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        for (int i = 1; i <= 50; i++)
        {
            numbers.Add(i);
        }

        PrintSpiral(numbers, 10);
    }

    static void PrintSpiral(List<int> list, int rowSize)
    {
        for (int i = 0; i < list.Count; i += rowSize)
        {
            var row = list.GetRange(i, Math.Min(rowSize, list.Count - i));
            if ((i / rowSize) % 2 == 1)
            {
                row.Reverse(); // Кожен другий рядок реверсується
            }
            Console.WriteLine(string.Join(" ", row));
        }
    }
}
