using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4.models
{
  internal class Engine
  {
    public string Type { get; set; }
    public int Power { get; set; }

    public Engine()
    {
      Type = "Nieznany";
      Power = 0;
      Console.WriteLine("Konstruktor Engine() - domyślny");
    }

    public Engine(string type, int power)
    {
      Type = type;
      Power = power;
      Console.WriteLine($"Konstruktor Engine(string, int): {type}, {power}HP");
    }

    public void Start()
    {
      Console.WriteLine($"Silnik {Type} ({Power}HP) uruchamia się");
    }

    public override string ToString()
    {
      return $"{Type} {Power}HP";
    }
  }
}
