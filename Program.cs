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

            c = a - b;

            Console.WriteLine("Результат вычитания: " + c);

            c = a * b;

            Console.WriteLine("Результат умножения: " + c);

            c = a / b;

            Console.WriteLine("Результат деления: " + c);

            c = Math.Cos(a);

            Console.WriteLine("Косинус первого числа: " + c);

            c = Math.Cos(b) ;

            Console.WriteLine("Косинус второго числа: " + c);



            Console.ReadKey();
        }
    }
}
