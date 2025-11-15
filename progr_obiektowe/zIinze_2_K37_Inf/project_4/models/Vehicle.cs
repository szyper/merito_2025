using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4.models
{
  abstract class Vehicle
  {
    public string Brand { get; set; }

    protected Vehicle()
    {
      Brand = "nieznana";
      Console.WriteLine("Konstruktor Vehicle() - domyślny");
    }

    protected Vehicle(string brand)
    {
      Brand = brand;
      Console.WriteLine($"Konstruktor Vehicle() - parametryczny: {brand}");
    }

    public abstract void ShowInfo();

    public virtual void Start()
    {
      Console.WriteLine($"{Brand} uruchamia się");
    }
  }
}
