using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    // Скрытые поля
    private string title;
    private string author;
    private int year;
    private string category;

    // Свойства для доступа к полям
    public string Title
    {
        get => title;
        set => title = value;
    }

    public string Author
    {
        get => author;
        set => author = value;
    }

    public int Year
    {
        get => year;
        set => year = value;
    }

    public string Category
    {
        get => category;
        set => category = value;
    }

    // Конструкторы
    public Book() { }

    public Book(string title, string author, int year, string category)
    {
        Title = title;
        Author = author;
        Year = year;
        Category = category;
    }

    // Переопределение метода ToString для вывода информации о книге
    public override string ToString()
    {
        return $"Название: {Title}, Автор: {Author}, Год: {Year}, Категория: {Category}";
    }
}

class HomeLibrary
{
    // Скрытое поле - список книг
    private List<Book> books = new List<Book>();

    // Метод для добавления книги
    public void AddBook(Book book)
    {
        books.Add(book);
    }

    // Метод для удаления книги
    public void RemoveBook(int index)
    {
        if (index >= 0 && index < books.Count)
        {
            books.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Некорректный индекс!");
        }
    }

    // Метод для поиска книги по автору
    public List<Book> FindByAuthor(string author)
    {
        return books.Where(book => book.Author == author).ToList();
    }

    // Метод для поиска книги по году издания
    public List<Book> FindByYear(int year)
    {
        return books.Where(book => book.Year == year).ToList();
    }

    // Метод для поиска книги по категории
    public List<Book> FindByCategory(string category)
    {
        return books.Where(book => book.Category == category).ToList();
    }

    // Метод для получения книги по номеру
    public Book GetBook(int index)
    {
        if (index >= 0 && index < books.Count)
        {
            return books[index];
        }
        else
        {
            Console.WriteLine("Некорректный индекс!");
            return null;
        }
    }

    // Метод для вывода всех книг
    public void DisplayBooks()
    {
        if (books.Count > 0)
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"Книга {i + 1}: {books[i]}");
            }
        }
        else
        {
            Console.WriteLine("Библиотека пуста!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объекта домашней библиотеки
        HomeLibrary library = new HomeLibrary();

        // Добавление книг в библиотеку
        library.AddBook(new Book("1984", "Джордж Оруэлл", 1949, "Фантастика"));
        library.AddBook(new Book("Война и мир", "Лев Толстой", 1869, "Роман"));
        library.AddBook(new Book("Преступление и наказание", "Федор Достоевский", 1866, "Драма"));

        // Вывод всех книг
        Console.WriteLine("Все книги в библиотеке:");
        library.DisplayBooks();

        // Поиск книги по автору
        Console.WriteLine("\nПоиск книг по автору 'Лев Толстой':");
        var authorBooks = library.FindByAuthor("Лев Толстой");
        authorBooks.ForEach(Console.WriteLine);

        // Удаление книги
        Console.WriteLine("\nУдаление второй книги...");
        library.RemoveBook(1);

        // Вывод всех книг после удаления
        Console.WriteLine("\nВсе книги после удаления:");
        library.DisplayBooks();

        // Получение книги по номеру
        Console.WriteLine("\nПолучение первой книги:");
        Book book = library.GetBook(0);
        Console.WriteLine(book != null ? book.ToString() : "Книга не найдена!");
    }
}
