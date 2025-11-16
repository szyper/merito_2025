using project_5.Models.Interfaces;
namespace project_5.Models.People;

public class Person : IPrintable, IWorkable
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Imię: {Name}, wiek: {Age}");
    }

    public virtual string GetDetails()
    {
        return $"Osoba: {Name}, wiek: {Age}";
    }

    public virtual void DoWork()
    {
        Console.WriteLine($"{Name} idzie do pracy");
    }
}