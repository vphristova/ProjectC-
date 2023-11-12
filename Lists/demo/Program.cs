using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> results = new List<int>();
        for (int x = 25001; x < 30000; x++)
        {
            if (x % 131 == 125 && x % 1965 == 125)
            {
                results.Add(x);
            }
        }

        foreach (int number in results)
        {
            Console.WriteLine(number);
        }
    }
}

