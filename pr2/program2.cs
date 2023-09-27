using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
    static void Main(string[] args)
    {
       int[,] matrix = new int[3, 3];
        
        // Введення елементів матриці від користувача
        Console.WriteLine("Введіть елементи матриці 3x3:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Елемент [{i + 1},{j + 1}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Знаходження суми елементів головної діагоналі
        int sum = 0;
        for (int i = 0; i < 3; i++)
        {
            sum += matrix[i, i];
        }

        // Виведення результату
        Console.WriteLine($"Сума елементів головної діагоналі: {sum}");
    }
    }
    
}
