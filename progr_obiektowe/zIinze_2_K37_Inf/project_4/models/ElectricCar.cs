using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4.models
{
  internal class ElectricCar : Car
  {
    public int BatteryCapacity { get; set; } // kWh
    public int Range { get; set; } // km a jednym ładowaniu

    public ElectricCar() : base()
    {
      BatteryCapacity = 75;
      Range = 400;
      Console.WriteLine("Konstrukto ElectricCar() - domyślny");
    }

    public ElectricCar(string brand, byte doors, int power, int battery, int range) : base(brand, doors, "Elektryczny", power)
    {
      BatteryCapacity = battery;
      Range = range;
      Console.WriteLine($"Konstruktor ElectricCar(): {brand}, bateria: {battery} kWh");
    }

    public void Charge()
    {
      Console.WriteLine($"Ładowanie baterii {BatteryCapacity} kWh. Zasięg: {Range} km");
    }

    public override void ShowInfo()
    {
      Console.WriteLine($"Elektryczny samochód: {Brand}, drzwi: {Doors}, silnik: {Engine}, bateria: {BatteryCapacity} kWh, zasięg: {Range} km");
    }

    public override void Start()
    {
      Console.WriteLine($"{Brand} (elektryczny) startuje bez dźwięku");
      Engine.Start();
    }
  }
}
