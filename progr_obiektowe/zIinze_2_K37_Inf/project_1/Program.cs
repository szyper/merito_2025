using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
  internal class Program
  {
    public enum Color
    {
      Czerwony,
      Zielony,
      Niebieski
    }

    public enum Type
    {
      Samochód,
      Motor,
      Ciężarówka,
      Suv
    }

    class Vehicle
    {
      public string Name { get; set; }
      public Color Color { get; set; }
      public double Speed { get; set; }
      public double Fuel { get; set; }
      public List<Type> Type { get; set; }
      public string Extra { get; set; }

      public void ShowData()
      {
        Console.WriteLine($"Nazwa: {Name}, kolor: {Color}, prędkość: {Speed}, rodzaj paliwa: {Fuel}, Typ: {string.Join(", ", Type)}.\nDodatkowe informacje: {Extra}");
      }
    }

    class Garage
    {
      public List<Vehicle> Vehicles { get; set; }
      public byte Capacity { get; set; }
      public void AddVehicles(Vehicle vehicle)
      {
        if (Vehicles.Count < Capacity)
        {
          Vehicles.Add(vehicle);
          Console.WriteLine($"Dodano {vehicle.Name} do garażu");
        }
        else
        {
          Console.WriteLine("Brak miejsc w garażu");
        }
      }

      public void RemoveVehicle(Vehicle vehicle)
      {
        if (Vehicles.Contains(vehicle))
        {
          Vehicles.Remove(vehicle);
          Console.WriteLine($"Usunięto {vehicle.Name} z garażu");
        }
        else
        {
          Console.WriteLine("Brak pojazdu w garażu");
        }
      }

      public void ShowVehicles()
      {
        Dictionary<Type, int> vehicleTypes = new Dictionary<Type, int>();

        foreach (Vehicle vehicle in Vehicles)
        {
          foreach (Type type in vehicle.Type)
          {
            if (vehicleTypes.ContainsKey(type))
            {
              vehicleTypes[type]++;
            }
            else
            {
              vehicleTypes[type] = 1;
            }
          }
        }

        foreach (KeyValuePair<Type, int> pair in vehicleTypes)
        {
          Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
      }
    }

    

    static void Main(string[] args)
    {
      Vehicle bike1 = new Vehicle();
      bike1.Name = "Yamaha";
      bike1.Type = new List<Type> { Type.Motor }; 
      Console.WriteLine(bike1.Name);
      bike1.ShowData();
      Console.Clear();

      Vehicle car1 = new Vehicle() { Name = "Fiat", Color = Color.Niebieski, Type = new List<Type> { Type.Samochód, Type.Suv}, Speed = 115, Fuel = 50, Extra = "126p" };
      car1.ShowData();

      Garage garage = new Garage();
      garage.Capacity = 2;

      garage.Vehicles = new List<Vehicle>();

      //garage.AddVehicles(bike1);
      garage.AddVehicles(car1);
      garage.AddVehicles(car1);

      Vehicle car2 = new Vehicle() { Name = "Fiat", Color = Color.Zielony, Type = new List<Type> { Type.Samochód, Type.Suv }, Speed = 115, Fuel = 50, Extra = "126p" };
      garage.AddVehicles(car2);

      garage.RemoveVehicle(car1);
      garage.AddVehicles(car2);
      garage.RemoveVehicle(car2);

      garage.ShowVehicles();

    }
  }
}
