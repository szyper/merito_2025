using project_5.Models.Interfaces;
namespace project_5.Models.People;

public class Worker : Person
{
    public string Profession { get; set; }

    public Worker(string name, int age, string profession) : base(name, age)
    {
        Profession = profession;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"{Name}, wiek: {Age}, zawód: {Profession}");
    }

    public override string GetDetails()
    {
        return $"Pracownik {Name}, wiek: {Age}, zawód: {Profession}";
    }

    public override void DoWork()
    {
        Console.WriteLine($"{Name} pracuje jako {Profession}");
    }
}