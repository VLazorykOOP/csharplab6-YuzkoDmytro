/*
using System;

interface IUserInterface
{
    void Display();
}

interface IAdminInterface
{
    void AdminOptions();
}

class Worker : IUserInterface
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public double Salary { get; set; }
    public int EmployeeId { get; set; }

    public void Show()
    {
        Console.WriteLine($"Ім'я: {Name}");
        Console.WriteLine($"Прізвище: {Surname}");
        Console.WriteLine($"Зарплата: {Salary}");
        Console.WriteLine($"ID працівника: {EmployeeId}");
    }

    public void Display()
    {
        Console.WriteLine("Інформація про працівника:");
        Show();
    }
}

class HR : Worker, IAdminInterface
{
    public string Position { get; set; }
    public DateTime HireDate { get; set; }

    public void AdminOptions()
    {
        Console.WriteLine($"Посада: {Position}");
        Console.WriteLine($"Дата прийняття на роботу: {HireDate.ToShortDateString()}");
    }
}

class Engineer : Worker
{
    public string Specialization { get; set; }
    public int Level { get; set; }

    public new void Show()
    {
        base.Show();
        Console.WriteLine($"Спеціалізація: {Specialization}");
        Console.WriteLine($"Рівень: {Level}");
    }
}

class Administration : Worker, IAdminInterface
{
    public string Department { get; set; }
    public int Experience { get; set; }

    public void AdminOptions()
    {
        Console.WriteLine($"Підрозділ: {Department}");
        Console.WriteLine($"Досвід роботи: {Experience} років");
    }
}

class Program
{
    static void Main(string[] args)
    {
        HR hr = new HR
        {
            Name = "Іван",
            Surname = "Петров",
            Salary = 2500,
            EmployeeId = 101,
            Position = "HR Manager",
            HireDate = new DateTime(2020, 5, 15)
        };

        Engineer engineer = new Engineer
        {
            Name = "Марія",
            Surname = "Іванова",
            Salary = 3500,
            EmployeeId = 102,
            Specialization = "Software Engineer",
            Level = 3
        };

        Administration admin = new Administration
        {
            Name = "Олексій",
            Surname = "Сидоров",
            Salary = 3000,
            EmployeeId = 103,
            Department = "Finance",
            Experience = 5
        };

        Console.WriteLine("Інформація про працівника (HR):");
        hr.Display();

        Console.WriteLine("\nІнформація про працівника (Інженер):");
        engineer.Display();

        Console.WriteLine("\nІнформація про працівника (Адміністрація):");
        admin.Display();

        Console.WriteLine("\nДодаткова інформація для адміністраторів:");
        Console.WriteLine("Інформація для HR:");
        hr.AdminOptions();

        Console.WriteLine("\nІнформація для Адміністрації:");
        admin.AdminOptions();
    }
}
*/

/*
using System;

interface INetInterface
{
    void NetMethod();
}

interface IPhoneDirectory : INetInterface
{
    void DisplayInfo();
    bool IsMatch(string criteria);
}

abstract class PhoneEntry : IPhoneDirectory
{
    public string Surname { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

    public void NetMethod()
    {
        Console.WriteLine("Метод з інтерфейсу .NET");
    }

    public abstract void DisplayInfo();

    public abstract bool IsMatch(string criteria);
}

class Person : PhoneEntry
{
    public override void DisplayInfo()
    {
        Console.WriteLine($"Персона: {Surname}");
        Console.WriteLine($"Адреса: {Address}");
        Console.WriteLine($"Номер телефону: {PhoneNumber}");
    }

    public override bool IsMatch(string criteria)
    {
        return Surname.Equals(criteria, StringComparison.OrdinalIgnoreCase);
    }
}

class Organization : PhoneEntry
{
    public string Name { get; set; }
    public string Fax { get; set; }
    public string ContactPerson { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Організація: {Name}");
        Console.WriteLine($"Адреса: {Address}");
        Console.WriteLine($"Номер телефону: {PhoneNumber}");
        Console.WriteLine($"Факс: {Fax}");
        Console.WriteLine($"Контактна особа: {ContactPerson}");
    }

    public override bool IsMatch(string criteria)
    {
        return Name.Equals(criteria, StringComparison.OrdinalIgnoreCase);
    }
}

class Friend : PhoneEntry
{
    public DateTime Birthday { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Друг: {Surname}");
        Console.WriteLine($"Адреса: {Address}");
        Console.WriteLine($"Номер телефону: {PhoneNumber}");
        Console.WriteLine($"Дата народження: {Birthday.ToShortDateString()}");
    }

    public override bool IsMatch(string criteria)
    {
        return Surname.Equals(criteria, StringComparison.OrdinalIgnoreCase);
    }
}

class Program
{
    static void Main(string[] args)
    {
        PhoneEntry[] phoneEntries = new PhoneEntry[]
        {
            new Person { Surname = "Іванов", Address = "вул. Лісова, 10", PhoneNumber = "+380971234567" },
            new Organization { Name = "Компанія А", Address = "пр. Перемоги, 20", PhoneNumber = "+380501234567", Fax = "+380501234568", ContactPerson = "Олександр" },
            new Friend { Surname = "Петров", Address = "вул. Сонячна, 5", PhoneNumber = "+380631234567", Birthday = new DateTime(1990, 5, 15) }
        };

        Console.WriteLine("Повна інформація з бази:");

        foreach (var entry in phoneEntries)
        {
            entry.DisplayInfo();
            Console.WriteLine();
        }

        Console.WriteLine("\nПошук у базі за прізвищем:");

        string searchCriteria = "Іванов";

        foreach (var entry in phoneEntries)
        {
            if (entry.IsMatch(searchCriteria))
            {
                entry.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
*/

using System;
using System.Collections;

abstract class Publication
{
    public string Title { get; set; }
    public string Author { get; set; }

    public abstract void PrintInfo();

    public bool IsAuthor(string authorName)
    {
        return Author.Equals(authorName, StringComparison.OrdinalIgnoreCase);
    }
}

class Book : Publication
{
    public int Year { get; set; }
    public string Publisher { get; set; }

    public override void PrintInfo()
    {
        Console.WriteLine($"Книга: {Title}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Рік видання: {Year}");
        Console.WriteLine($"Видавництво: {Publisher}");
    }
}

class Article : Publication
{
    public string Journal { get; set; }
    public int Issue { get; set; }
    public int Year { get; set; }

    public override void PrintInfo()
    {
        Console.WriteLine($"Стаття: {Title}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Журнал: {Journal}, №{Issue}, {Year}");
    }
}

class ElectronicResource : Publication
{
    public string Link { get; set; }
    public string Annotation { get; set; }

    public override void PrintInfo()
    {
        Console.WriteLine($"Електронний ресурс: {Title}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Посилання: {Link}");
        Console.WriteLine($"Анотація: {Annotation}");
    }
}

class Catalog : IEnumerable
{
    private Publication[] publications;

    public Catalog(int n)
    {
        publications = new Publication[n];
    }

    public void AddPublication(int index, Publication publication)
    {
        publications[index] = publication;
    }

    public void PrintCatalog()
    {
        foreach (var publication in publications)
        {
            publication.PrintInfo();
            Console.WriteLine();
        }
    }

    public void SearchByAuthor(string authorName)
    {
        Console.WriteLine($"Видання автора {authorName}:");
        foreach (var publication in publications)
        {
            if (publication.IsAuthor(authorName))
            {
                publication.PrintInfo();
                Console.WriteLine();
            }
        }
    }

    public IEnumerator GetEnumerator()
    {
        return publications.GetEnumerator();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Catalog catalog = new Catalog(3);
        catalog.AddPublication(0, new Book { Title = "Таємниця космосу", Author = "Іванов", Year = 2020, Publisher = "Видавництво А" });
        catalog.AddPublication(1, new Article { Title = "Нові дослідження у фізиці", Author = "Петров", Journal = "Фізика", Issue = 3, Year = 2021 });
        catalog.AddPublication(2, new ElectronicResource { Title = "Вступ до програмування", Author = "Сидоренко", Link = "http://example.com", Annotation = "Посібник для початківців" });

        catalog.PrintCatalog();

        catalog.SearchByAuthor("Іванов");

        Console.WriteLine("\nВикористання оператора foreach:");
        foreach (var publication in catalog)
        {
            Console.WriteLine(publication);
        }
    }
}
