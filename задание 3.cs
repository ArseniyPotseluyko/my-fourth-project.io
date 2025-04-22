using System;

class StringMatrix
{
    private readonly string[,] matrix; // Скрытое поле для хранения двумерного массива
    private readonly int rows;         // Количество строк
    private readonly int cols;         // Количество столбцов

    // Конструктор для создания матрицы фиксированных размеров
    public StringMatrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        matrix = new string[rows, cols];
    }

    // Открытое свойство для получения размеров матрицы
    public int Rows => rows;
    public int Cols => cols;

    // Индексатор для доступа к элементам массива
    public string this[int i, int j]
    {
        get
        {
            if (i >= 0 && i < rows && j >= 0 && j < cols)
            {
                return matrix[i, j];
            }
            else
            {
                throw new IndexOutOfRangeException("Индексы выходят за границы массива.");
            }
        }
        set
        {
            if (i >= 0 && i < rows && j >= 0 && j < cols)
            {
                matrix[i, j] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Индексы выходят за границы массива.");
            }
        }
    }

    // Перегрузка оператора == для сравнения массивов
    public static bool operator ==(StringMatrix matrix1, StringMatrix matrix2)
    {
        if (matrix1.rows != matrix2.rows || matrix1.cols != matrix2.cols)
        {
            return false; // Размеры не совпадают
        }

        for (int i = 0; i < matrix1.rows; i++)
        {
            for (int j = 0; j < matrix1.cols; j++)
            {
                if (matrix1[i, j] != matrix2[i, j])
                {
                    return false; // Элементы не совпадают
                }
            }
        }
        return true; // Массивы равны
    }

    // Перегрузка оператора !=
    public static bool operator !=(StringMatrix matrix1, StringMatrix matrix2)
    {
        return !(matrix1 == matrix2);
    }

    // Переопределение методов для сравнения
    public override bool Equals(object obj)
    {
        if (obj is StringMatrix otherMatrix)
        {
            return this == otherMatrix;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return matrix.GetHashCode() ^ rows.GetHashCode() ^ cols.GetHashCode();
    }

    // Метод для вывода матрицы в консоль
    public void PrintMatrix()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание двух матриц
        StringMatrix matrix1 = new StringMatrix(2, 2);
        StringMatrix matrix2 = new StringMatrix(2, 2);

        // Заполнение матриц
        matrix1[0, 0] = "Привет";
        matrix1[0, 1] = "Мир";
        matrix1[1, 0] = "C#";
        matrix1[1, 1] = "Матрица";

        matrix2[0, 0] = "Привет";
        matrix2[0, 1] = "Мир";
        matrix2[1, 0] = "C#";
        matrix2[1, 1] = "Матрица";

        // Вывод матриц
        Console.WriteLine("Матрица 1:");
        matrix1.PrintMatrix();

        Console.WriteLine("\nМатрица 2:");
        matrix2.PrintMatrix();

        // Проверка на равенство
        Console.WriteLine($"\nМатрицы равны: {matrix1 == matrix2}");
    }
}
