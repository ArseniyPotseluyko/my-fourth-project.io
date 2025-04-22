using System;

class Program
{
    // Метод для вычисления значения функции f(x)
    static double CalculateFunction(double x, double a, double b)
    {
        if (Math.Abs(x) < 3)
        {
            return Math.Sin(x + a);
        }
        else if (Math.Abs(x) >= 3 && Math.Abs(x) <= 9)
        {
            return Math.Sqrt(Math.Pow(x, 2) + a) / Math.Sqrt(Math.Pow(x, 2) + b);
        }
        else
        {
            return Math.Sqrt(Math.Pow(x, 2) + a) - Math.Sqrt(Math.Pow(x, 2) + b);
        }
    }

    static void Main(string[] args)
    {
        // Ввод параметров a, b, h с клавиатуры
        Console.Write("Введите значение a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите шаг h: ");
        double h = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите начальное значение диапазона x (a): ");
        double startX = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите конечное значение диапазона x (b): ");
        double endX = Convert.ToDouble(Console.ReadLine());

        // Вывод заголовка таблицы
        Console.WriteLine("\nТаблица значений функции f(x):");
        Console.WriteLine(" x | f(x)");
        Console.WriteLine("-----------------------------");

        // Построение таблицы значений функции
        for (double x = startX; x <= endX; x += h)
        {
            double fx = CalculateFunction(x, a, b);
            Console.WriteLine($"{x,6:F2} | {fx,6:F4}");
        }
    }
}
