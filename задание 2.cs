using System;

class Program
{
    // Процедура PowerA234, вычисляющая степени числа A
    static void PowerA234(double A, out double B, out double C, out double D)
    {
        B = Math.Pow(A, 2); // Вторая степень
        C = Math.Pow(A, 3); // Третья степень
        D = Math.Pow(A, 4); // Четвертая степень
    }

    static void Main(string[] args)
    {
        // Массив чисел для вычисления степеней
        double[] numbers = { 2.0, 3.0, 4.0, 5.0, 6.0 };

        Console.WriteLine("Входное число | Вторая степень | Третья степень | Четвертая степень");
        Console.WriteLine("---------------------------------------------------------");

        foreach (double number in numbers)
        {
            PowerA234(number, out double B, out double C, out double D);
            Console.WriteLine($"{number,12} | {B,14:F2} | {C,14:F2} | {D,14:F2}");
        }
    }
}
