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
       int[] numbers = new int[10];

        Console.WriteLine("Введіть 10 цілих чисел:");

        // Зчитуємо 10 чисел з консолі і зберігаємо їх у масиві
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Елемент {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out numbers[i]) == false)
            {
                Console.WriteLine("Невірний формат числа. Введіть ціле число.");
                i--; // Повторюємо введення для цього елемента
            }
        }

        int minPositive = FindMinPositive(numbers);

        if (minPositive != int.MaxValue)
        {
            Console.WriteLine($"Найменше додатнє число у списку: {minPositive}");
        }
        else
        {
            Console.WriteLine("Додатніх чисел в списку немає.");
        }
    }

    static int FindMinPositive(int[] numbers)
    {
        int minPositive = int.MaxValue;

        foreach (int number in numbers)
        {
            if (number > 0 && number < minPositive)
            {
                minPositive = number;
            }
        }

        return minPositive;
    
    }
    }
}
