using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
  internal class Program
  {
    // klasa bazowa
    class Vehicle
    {
      // dodać konstruktory do klasy bazowej (base) i klas pochodnych
      public string Brand { get; set; }
      public int Year { get; set; }

      // konstruktor klasy bazowej
      public Vehicle(string brand, int year)
      {
        Brand = brand;
        Year = year;
      }

      public void DisplayInfo()
      {
        Console.WriteLine($"Marka: {Brand}, rok produkcji: {Year}");
      }
    }

    //klasa pochodna
    class Car : Vehicle
    {
      public int NumberOfDoors { get; set; }
      
      // konstruktor klasy pochodnej
      public Car(string brand, int year, int numberOfDoors) : base(brand, year)
      {
        NumberOfDoors = numberOfDoors;
      }

      public void DisplayDetails()
      {
        Console.WriteLine($"Samochód ma {NumberOfDoors}");
      }
    }

    // klasa pochodna
    class Bicycle : Vehicle
    {
      public bool HasBasket { get; set; }

      // konstruktor klasy pochodnej
      public Bicycle(string brand, int year, bool hasBasket) :base(brand, year)
      {
        HasBasket = hasBasket;
      }

      public void DisplayDetails()
      {
        string basket = HasBasket ? "ma koszyk" : "nie ma koszyka";
        Console.WriteLine($"Rower {basket}");
      }
    }

    // klasa pochodna
    class Boat : Vehicle
    {
      // prywatne pola
      private double length;
      private int enginePower;

      public Boat(string brand, int year, double length, int enginePower) : base(brand, year)
      {
        Length = length;
        EnginePower = enginePower;
      }

      // właściwość Length z walidacją
      public double Length
      {
        get
        {
          return length;
        }

        set
        {
          if (value > 0)
          {
            length = value;
          }
          else
          {
            Console.WriteLine("Długość łodzi musi być większa od 0");
          }
        }
      }

      public int EnginePower
      {
        get
        {
          return enginePower;
        }
        set
        {
          if (value > 0)
          {
            enginePower = value;
          }
          else
          {
            Console.WriteLine("Moc silnika łodzi musi być większa od 0");
          }
        }
      }

      public void DisplayDetails()
      {
        Console.WriteLine($"Łódź ma długość: {Length} metrów i moc silnika {EnginePower} KM");
      }

    }

    static void Main(string[] args)
    {
      //Car c1 = new Car
      //{
      //  Brand = "Toyota",
      //  Year = 2020,
      //  NumberOfDoors = 4
      //};

      //Bicycle b1 = new Bicycle
      //{
      //  Brand = "Romet",
      //  Year = 2024,
      //  HasBasket = true
      //};

      Car c1 = new Car("BMW", 2000, 4);

      c1.DisplayInfo();
      c1.DisplayDetails();
      Console.WriteLine();

      Bicycle b1 = new Bicycle("Romet", 2022, true);

      b1.DisplayInfo();
      b1.DisplayDetails();

      Boat boat1 = new Boat("Yamaha", 2023, 7.7, 250);
      boat1.DisplayDetails();

      boat1.Length = -5;
      boat1.Length = 5;
      boat1.DisplayDetails();

      boat1.EnginePower = -200;



    }
  }
}
