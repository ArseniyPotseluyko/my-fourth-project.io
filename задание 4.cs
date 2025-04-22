using System;

class Program
{
    // Метод для нахождения наименьшего из двух чисел
    static int Min(int a, int b)
    {
        return a < b ? a : b; // Возвращает меньшее из двух чисел
    }

    // Перегрузка метода для нахождения наименьшего из трех чисел
    static int Min(int a, int b, int c)
    {
        return Min(Min(a, b), c); // Сравнивает a, b и c, используя метод Min(a, b)
    }

    static void Main(string[] args)
    {
        // Ввод чисел с клавиатуры
        Console.Write("Введите a1: ");
        int a1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите b1: ");
        int b1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите a2: ");
        int a2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите b2: ");
        int b2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите c2: ");
        int c2 = Convert.ToInt32(Console.ReadLine());

        // Вычисление Min(a1, b1) и Min(a2, b2, c2)
        int min1 = Min(a1, b1);
        int min2 = Min(a2, b2, c2);

        // Вычисление результата произведения
        int result = min1 * min2;

        // Вывод результатов
        Console.WriteLine($"\nMin(a1, b1) = {min1}");
        Console.WriteLine($"Min(a2, b2, c2) = {min2}");
        Console.WriteLine($"Результат Min(a1, b1) * Min(a2, b2, c2) = {result}");
    }
}
