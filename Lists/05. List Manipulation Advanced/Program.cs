using System.Linq;
using System.Windows.Input;
using System.Xml.Linq;

List<int> numbers = Console.ReadLine()
  .Split(' ').Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{

    if (command.StartsWith("Contains"))
    {
        int numberToContains = int.Parse(command.Split(" ")[1]);

        if (numbers.Contains(numberToContains))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (command.StartsWith("PrintEven"))
    {
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
    else if (command.StartsWith("PrintOdd"))
    {
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
    else if (command.StartsWith("GetSum"))
    {
        Console.WriteLine(numbers.Sum());
    }
    else if (command.StartsWith("Filter"))
    {
        string conditionToFilter = command.Split(" ")[1];
        int numberToFilter = int.Parse(command.Split(" ")[2]);

        if (conditionToFilter == ">=")
        {
            List<int> filterNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number >= numberToFilter)
                {
                    filterNumbers.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ", filterNumbers));

        }
        else if (conditionToFilter == "<=")
        {
            List<int> filterNumbers1 = new List<int>();

            foreach (int number in numbers)
            {
                if (number <= numberToFilter)
                {
                    filterNumbers1.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ", filterNumbers1));
        }
        else if (conditionToFilter == "<")
        {
            List<int> filterNumbers2 = new List<int>();

            foreach (int number in numbers)
            {
                if (number < numberToFilter)
                {
                    filterNumbers2.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ", filterNumbers2));
        }
        else if (conditionToFilter == ">")
        {
            List<int> filterNumbers3 = new List<int>();

            foreach (int number in numbers)
            {
                if (number > numberToFilter)
                {
                    filterNumbers3.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ", filterNumbers3));
        }
    }
    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));



