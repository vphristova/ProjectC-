List<int> numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToList();
string commad = Console.ReadLine();

while (commad != "end")
{
    if (commad.StartsWith("Add"))
    {
        int numberToAdd = int.Parse(commad.Split(" ")[1]);
        numbers.Add(numberToAdd);
    }
    else if (commad.StartsWith("RemoveAt"))
    {
        int indexToRemoveAt = int.Parse(commad.Split(" ")[1]);
        numbers.RemoveAt(indexToRemoveAt);
    }
    else if (commad.StartsWith("Remove"))
    {
        int numberToRemove = int.Parse(commad.Split(" ")[1]);
        numbers.Remove(numberToRemove);
    }
    else if (commad.StartsWith("Insert"))
    {
        int indexToInsert = int.Parse(commad.Split(" ")[2]);
        int numberToInsert = int.Parse(commad.Split(" ")[1]);
        numbers.Insert(indexToInsert, numberToInsert);
    }


    commad = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));
