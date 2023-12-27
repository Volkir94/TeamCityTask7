
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Программа на C# для вычисления числа Фибоначчи по номеру.");

        // Ввод номера
        Console.Write("Введите номер числа Фибоначчи: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
        {
            // Вычисление числа Фибоначчи
            int result = Fibonacci(n);

            // Вывод результата
            Console.WriteLine($"Число Фибоначчи под номером {n} равно: {result}");
        }
}

    // Рекурсивная функция для вычисления числа Фибоначчи
    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
