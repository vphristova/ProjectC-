namespace _04._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int CalcRectArea(int width, int lenght)
            { 
                return width * lenght;
            }
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int area = CalcRectArea(width, lenght);
            Console.WriteLine(area);
        }
    }
}