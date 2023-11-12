int[] firstNumbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

int[] secondNumbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

for (int index = 0; index <= firstNumbers.Length - 1; index++)
{
    for (int index1 = 0; index1 <= secondNumbers.Length - 1; index1++)
    {
        if (firstNumbers[index] == secondNumbers[index1])
        {
            Console.Write(firstNumbers[index] + " ");
        }
    }
}
