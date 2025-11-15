using project_4.models;

namespace project_4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*
      var car1 = new Car();
      car1.ShowInfo();
      car1.Start();
      Console.WriteLine("\n\n");

      var car2 = new Car("Tesla Model S", 4, "Elektryczny", 1020);
      car2.ShowInfo();
      car2.Start();
      */

      Vehicle[] vehicles =
      [
        new Car("Fiat", 4, "Benzynowy", 54),
        new ElectricCar("Tesla model S", 4, 450, 82, 560),
        new Motorcycle("Harley-Davidson", true, 150),
        new Car()
      ];

      foreach (var vehicle in vehicles)
      {
        vehicle.ShowInfo();
        vehicle.Start();
      }
    }
  }
}
