using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
  internal class Program
  {
    enum FavoriteColor
    {
      Czerwony,
      Zielony,
      Niebieski
    }
    class Person
    {
      //prywatne pola
      private string _name;
      private byte _age;
      private int _birthYear;

      public int BirthYear
      {
        get
        {
          return DateTime.Now.Year - Age;
        }

        private set
        {
          _birthYear = value;
        }
      }

      //właściowści publiczne z walidacją
      public string Name 
      {
        get { return _name;  }
        set
        {
          if (string.IsNullOrWhiteSpace(value))
          {
            Console.WriteLine("Błąd: Name ne może być pusty. Ustawiono domyślną wartość 'Nieznane'");
            _name = "Nieznane";
          }
          else
          {
            _name = value;
          }
        }
      }
      public byte Age 
      {
        get { return _age; }
        set
        {
          if (value < 0 || value > 140)
          {
            Console.WriteLine($"Błąd: Age musi być w przedziale 0-140. Ustawiono domyślną wartość 0.");
            _age = 0;
          }
          else
          {
            _age = value;
          }
        }
      }
      public FavoriteColor Color { get; set; }

      // konstruktor domyślny
      public Person()
      {
        Name = "Nieznane";
        Age = 0;
        Console.WriteLine("\nWywołano konstruktor domyślny");
      }

      //konstruktor parametrczny
      public Person(string name)
      {
        Name = name;
        Console.WriteLine("Konstruktor z jednym parametrem");
      }

      public Person(string name, byte age) : this(name)
      {
        Age = age;
        Console.WriteLine("\nKonstruktor z dwoma parametrami");
      }

      public Person(string name, byte age, FavoriteColor color) : this(name, age)
      {
        Color = color;
        Console.WriteLine("\nKonstruktor z trzema parametrami");
      }

      // konstruktor kopiujący
      public Person(Person otherPerson)
      {
        Name = otherPerson.Name;
        Age = otherPerson.Age;
        Color = otherPerson.Color;
        Console.WriteLine("Wywołano konstruktor kopiujący");
      }

      public void Info()
      {
        Console.WriteLine($"Imię: {Name}, wiek: {Age}, kolor: {Color}, data urodzenia: {BirthYear}");
      }

    }
    static void Main(string[] args)
    {
      Person p1 = new Person();
      p1.Info();

      Person p2 = new Person("Jan");
      p2.Info();

      Person p3 = new Person("Anna", 22);
      p3.Info();

      Person p4 = new Person("Paweł", 150, FavoriteColor.Niebieski);
      Console.WriteLine("Wiek: " + p4.Age);
      p4.Info();

      Person p5 = new Person(p3);
      p5.Color = FavoriteColor.Zielony;
      p5.Info();

    }
  }
}
