using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4.models
{
  class Car : Vehicle
  {
    public byte Doors { get; set; }
    public Engine Engine { get; set; }

    public Car() : base()
    {
      Doors = 4;
      Engine = new Engine();
      Console.WriteLine("Konstruktor Car() - domyślny");
    }

    public Car(string brand, byte doors, string engineType, int enginePower) : base(brand)
    {
      Brand = brand;
      Doors = doors;
      Engine = new Engine(engineType, enginePower);
      Console.WriteLine($"Konstruktor Car(string, byte, string, int): {brand}, drzwi: {doors}");
    }

    public override void ShowInfo()
    {
      Console.WriteLine($"Samochód: {Brand}, liczba drzwi: {Doors}, silnik: {Engine}");
    }

    public override void Start()
    {
      Console.WriteLine($"Samochód: {Brand} z {Doors} drzwiami uruchamia się");
    }
  }
}
