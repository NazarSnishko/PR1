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
    Random random = new Random();
        int secretNumber = random.Next(0, 11);
        int attempts = 3;

        Console.WriteLine("Гра 'Вгадай число'!");
        Console.WriteLine("Комп'ютер загадав число від 0 до 10. Вам потрібно вгадати його.");

        for (int attempt = 1; attempt <= attempts; attempt++)
        {
            Console.Write($"Спроба {attempt}: Введіть ваш варіант: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int guess))
            {
                if (guess == secretNumber)
                {
                    Console.WriteLine("Вітаємо! Ви вгадали число.");
                    break;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Загадане число більше.");
                }
                else
                {
                    Console.WriteLine("Загадане число менше.");
                }
            }
            else
            {
                Console.WriteLine("Некоректний ввід. Будь ласка, введіть ціле число від 0 до 10.");
                attempt--; // Зменшуємо лічильник спроб, щоб не зарахувувати некоректний ввід.
            }
        }

        Console.WriteLine($"Гра закінчена. Загадане число було: {secretNumber}.");
    }
    
    }
}
