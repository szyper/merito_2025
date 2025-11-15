using System.Reflection.Metadata.Ecma335;

namespace wyklad_w_konstruktory_destruktory
{
  internal class Program
  {
    class Person
    {
      public string name;
      public int age;

      public Person()
      {
        name = "Nieznane";
        age = 18;
      }

      public Person(string name)
      {
        this.name = name;
      }
    }

    class Student
    {
      public string firstName;
      public string studentId;

      public Student()
      {
        Console.Write("Podaj swoje imię: ");
        firstName = Console.ReadLine();

      }

      public Student(string FirstName, string StudentId)
      {
        firstName = FirstName;
        studentId = StudentId;
      }
    }

    class Car
    {
      public string brand;
      public string model;
      public int year;

      public Car(string brand)
      {
        this.brand = brand;
      }

      public Car(string brand, string model, int year)
      {
        this.brand = brand;
        this.model = model;
        this.year = year;
      }

      public Car(Car other)
      {
        brand = other.brand;
        model = other.model;
        year = other.year;
      }
    }

    static void Main(string[] args)
    {
      Person p = new Person();
      Console.WriteLine(p.age); //0
      Console.WriteLine(p.name);

      Person p1 = new Person("Jan");
      Console.WriteLine(p1.name);

      Student s = new Student();
      Console.WriteLine(s.firstName);

      Console.Write("Podaj swoje imię: ");
      string name = Console.ReadLine();

      Console.Write("Podaj id: ");
      string id = Console.ReadLine();

      Student s2 = new Student(name, id);
      Console.WriteLine($"Imię: {s2.firstName}, id: {s2.studentId}");

      Car c = new Car("VW");
      Console.WriteLine();

      Car c3 = new Car("Fiat", "126p", 1984);
      Console.WriteLine($"Marka: {c3.brand}, model: {c3.model}, rok produkcji: {c3.year}");
      Car cn = new Car(c3);
      Console.WriteLine($"Marka: {cn.brand}, model: {cn.model}, rok produkcji: {cn.year}");

      c3.brand = "Ferrari";
      Console.WriteLine(cn.brand); //Fiat
      cn.brand = "Porsche";
      Console.WriteLine(cn.brand); //Porsche
      Console.WriteLine(c3.brand); //Ferrari




    }
  }
}
