﻿namespace _03._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void PrintLine(int start, int end)
            {
                for (int i = start; i <= end; i++)
                { 
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            static void PrintTriangle(int num)
            {
                for (int currentLine = 1; currentLine <= num; currentLine++)
                {
                    PrintLine(1, currentLine);
                }
                for (int currentLine = num - 1; currentLine >= 1; currentLine--)
                {
                    PrintLine(1, currentLine);
                }
            }
            int number = int.Parse(Console.ReadLine());

            PrintTriangle(number);
        }        
    }
}