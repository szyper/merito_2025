using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4.models
{
  internal class Motorcycle : Vehicle
  {
    public bool HasSidecar { get; set; }
    public Engine Engine { get; set; }

    public Motorcycle() : base()
    {
      HasSidecar = false;
      Engine = new Engine("Benzynowy", 100);
      Console.WriteLine("Konstruktor Motorcycle() - domyślny");
    }

    public Motorcycle(string brand, bool hasSidecar, int power)
    {
      HasSidecar = hasSidecar;
      Engine = new Engine("Benzynowy", power);
      Console.WriteLine($"Konstruktor Motorcycle(): {brand}, kosz: {hasSidecar}");
    }

    public override void ShowInfo()
    {
      Console.WriteLine($"Motocykl: {Brand}, kosz: {(HasSidecar ? "tak" : "nie")}");
    }

    public override void Start()
    {
      Console.WriteLine($"Motocykl {Brand} uruchomiony");
      Engine.Start();
    }
  }
}
