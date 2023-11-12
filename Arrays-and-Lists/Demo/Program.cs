// See https//3, 45, 67, 89
List<int> numbers = new List<int>();

List<int>? nullList = null;

List<int> emptyList = new();

//празен лист
List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

//добавяне на елементи
numbers.Add(3);
numbers.Add(45);
numbers.Add(67);
numbers.Add(89);

//Assert - когато метода има входен параметър лист и ни връща лист
//CollectionAssert.AreEqual(emptyList, result);

// Act & Assert - - Когато при unitests мето връща Exception
//Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);

//размер на лист = брой на елементи
Console.WriteLine(numbers.Count);

//първия елемент на листа -> 0 индекс
Console.WriteLine(numbers[0]);

//последен елемент на листа
Console.WriteLine(numbers[numbers.Count - 1]);

//премахваме първото срещане на елементa от листа
numbers.Remove(45);

//премахваме елемент от списъка на дадения индекс
numbers.RemoveAt(0);

//вмъкване на елемент
//{3, 4, 6, 78}
numbers.Insert(1, 123);

//проверка дали даден елемент съществува в списъка
//true -> ako имаме такъв елемент в списъка
//false -> ако нямаме такъв елемент в списъка
Console.WriteLine(numbers.Contains(123)); //true
Console.WriteLine(numbers.Contains(654)); //false

int result = numbers[0] + numbers[3];

//принтиране на елементите
//1. for -> работим с индексите на елементите
for (int index = 0; index <= numbers.Count - 1; index++)
{
    Console.WriteLine(numbers[index]);
}

//2. foreach -> работим с елементите, без значение от индексите
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

//3. string.Join
//{3, 4, 5, 8}
Console.WriteLine(string.Join(", ", numbers));


//Arrays vs Lists
//1. кога да използваме масив -> съвкупност от елементи, която няма да модифицираме
int[] numbersArray = { 2, 3, 4, 5 };

//2. кога даизползваме лист -> съвкупност от елементи, които ще модифицираме
List<int> prices = new List<int>() { 3, 2, 13, 9, 34 };
//сортира елемнтите в списъка в ascending order (нарастващ ред)
//{ 3, 2, 13, 9, 34 }.Sort() -> {2, 3, 9, 13, 34}
prices.Sort();
//сортира елемнтите в списъка в descending order (намаляващ ред)
//{ 3, 2, 13, 9, 34 }.Sort() -> {2, 3, 9, 13, 34}.Reverse() -> {34, 13, 9 , 3, 2}
prices.Sort();
prices.Reverse();


List<string> names = new List<string>() { "Ivan", "Georgi", "Pesho", "Misho" };
//сортира елемнтите в списъка в ascending order (азбучен ред A - Z)
//{ "Ivan", "Georgi", "Pesho", "Misho" } -> {"Georgi", "Ivan", "Misho", "Pesho"}
names.Sort();

