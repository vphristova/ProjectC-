using System.Globalization;

int n = int.Parse(Console.ReadLine());

List<string> products = new List<string>();

for (int i = 1; i <= n; i++)
{ 
    string product = Console.ReadLine();
    products.Add(product);
}
products.Sort();

int numbers = 1;

foreach (string product in products)
{
    Console.WriteLine(numbers + "." + product);
    numbers++;
}
