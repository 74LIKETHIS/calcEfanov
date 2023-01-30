using System;

namespace calcEfanov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");

            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Второе число");

            double b = Convert.ToDouble(Console.ReadLine());

            double c;

            c = a + b;

            Console.WriteLine("Результат сложения: " + c);

            Console.ReadKey();
        }
    }
}
