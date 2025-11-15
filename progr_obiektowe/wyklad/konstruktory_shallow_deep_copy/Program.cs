namespace konstruktory_shallow_deep_copy
{
  internal class Program
  {
    public class Engine
    {
      public int HorsePower { get; set; }
      public double Capacity { get; set; }
      
      // pole statyczne - wspólne dla wszystkich obiektów Engine
      public static int EngineCount;
      
      // konstruktor statyczny
      static Engine()
      {
        EngineCount = 0;
        Console.WriteLine("Statyczny konstruktor Engine został wywołany");
      }

      public Engine(int horsePower, double capacity)
      {
        HorsePower = horsePower;
        Capacity = capacity;
        EngineCount++;
      }

      public Engine(Engine other)
      {
        HorsePower = other.HorsePower;
        Capacity = other.Capacity;
        EngineCount++;
      }

      ~Engine()
      {
        Console.WriteLine("Destruktor silnika został wywołany");
        EngineCount--;
      }
      
      public override string ToString()
      {
        return $"Moc silnika: {HorsePower}HP, {Capacity}L, liczba silników: {EngineCount}";
      }
    }
    
    public class Car
    {
      public string Brand { get; set; }
      public Engine Engine { get; set; }
      public static int CarCount;

      static Car()
      {
        CarCount = 0;
        Console.WriteLine("Statyczny konstruktor Car został wywołany");
      }

      public Car(string brand, Engine engine)
      {
        Brand = brand;
        Engine = engine;
        CarCount++;
      }

      public Car(Car other)
      {
        Brand = other.Brand;
        Engine = new Engine(other.Engine);
        CarCount++;
      }

      ~Car()
      {
        Console.WriteLine("Destruktor samochodu został wywołany");
        CarCount--;
      }
      
      public override string ToString()
      {
        return $"Marka samochodu: {Brand}, {Engine}, ilość samochodów: {CarCount}";
      }
    }

    public class ElectricCar : Car
    {
      public int BatteryCapacity { get; set; }

      public enum DrivingMode { Eco, Normal, Sport }
      public DrivingMode Mode { get; private set; } = DrivingMode.Normal;

      public ElectricCar(string brand, Engine engine, int batteryCapacity) : base(brand, engine)
      {
        BatteryCapacity = batteryCapacity;
      }

      public ElectricCar(ElectricCar other) : base(other)
      {
        BatteryCapacity = other.BatteryCapacity;
        Mode = other.Mode;
      }

      ~ElectricCar()
      {
        Console.WriteLine("Destruktor samochodu elektrycznego został wywołany");
      }
      
      public override string ToString()
      {
        return $"Samochód elektyczny: {Brand}, {Engine}, bateria: {
        BatteryCapacity}kWh, tryb jazdy: {Mode}";
      }
    }
    static void Main(string[] args)
    {
      Car car1 = new Car("Audi", new Engine(400, 2.0));
      Car car2 = new Car(car1);

      car2.Engine.HorsePower = 500;

      Console.WriteLine($"car1: {car1.Brand}, {car1.Engine.HorsePower}HP");
      Console.WriteLine($"car2: {car2.Brand}, {car2.Engine.HorsePower}HP");
      
      car1.Engine.HorsePower = 1000;
      Console.WriteLine($"car1: {car1.Brand}, {car1.Engine.HorsePower}HP");
      Console.WriteLine($"car2: {car2.Brand}, {car2.Engine.HorsePower}HP");

      Console.WriteLine("====================");
      Console.WriteLine(car1);
      Console.WriteLine("====================");

      ElectricCar eCar1 = new ElectricCar("Tesla", new Engine(400, 0), 100);

      ElectricCar eCar2 = new ElectricCar(eCar1);
      eCar2.Engine.HorsePower = 222;

      Console.WriteLine(car1);
      Console.WriteLine(eCar1);
      Console.WriteLine(eCar2);

      car1 = null;
      eCar1 = null;
      eCar2 = null;
      
      GC.Collect();
      GC.WaitForPendingFinalizers();

      Console.WriteLine("Koniec programu");
    }
  }
}
