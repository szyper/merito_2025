using project_5.Models.Interfaces;
namespace project_5.Models.People;

public class Student : Person
{
    public string University { get; set; }
        
    public Student(string name, int age, string university) : base(name, age)
    {
        University = university;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Imię: {Name}, wiek: {Age}, uczelnia: {University} ");
    }

    public override string GetDetails()
    {
        return $"Student {Name}, {Age} lat, uczelnia: {University}";
    }

    public override void DoWork()
    {
        Console.WriteLine($"{Name} uczy się na studiach");
    }
}