using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введите начальное число: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите конечное число: ");
            int m = int.Parse(Console.ReadLine());
            int rndNum = rnd.Next(n, m);
            Console.WriteLine("Случайное число получено...");
            Console.Write("Попробуйте угадать это число: ");
            int yourNum = int.Parse(Console.ReadLine());
            if (yourNum == rndNum)
            {
                Console.WriteLine($"Поздравляю! Вы угадали!");
            }
            else
            {
                Console.WriteLine($"К сожалению вы не угадали, верное число - {rndNum}");
            }

            Console.ReadKey();
        }
    }
}
