namespace project_2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Pętle: for, while, do-while");

      while (true)
      {
        Console.WriteLine("Wybierz rodzaj pętli:");
        Console.WriteLine("1 - pętla for");
        Console.WriteLine("2 - pętla while");
        Console.WriteLine("3 - pętla do-while");
        Console.WriteLine("0 - wyjście z programu");

        Console.Write("\nTwój wybór: ");

        //string? choice = Console.ReadLine();
        //string input = choice ?? "";
        string choice = Console.ReadLine() ?? "";

        if (choice == "0")
        {
          Console.WriteLine("Koniec programu");
          break;
        }

        Console.WriteLine($"Pętla FOR liczby od 1 - 10");

        Console.Write("Podaj wartość początkową: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Podaj wartość końcową: ");
        int end = int.Parse(Console.ReadLine());
        //int i;

        switch (choice)
        {
          case "1":
            for (int i = start; i <= end; i++)
            {
              Console.Write(i + " ");
            }
            Console.WriteLine("\nKoniec pętli FOR");
            break; ;

          case "2":
            Console.WriteLine($"Pętla WHILE - liczby od {start} do {end}");
            int j = start;
            while (j <= end)
            {
              Console.Write(j + " ");
              j++;
            }
            Console.WriteLine("\nKoniec pętli WHILE");
            break;

          case "3":
            Console.WriteLine($"Pętla DO-WHILE - liczby od {start} do {end}");
            int k = start;
            do
            {
              Console.Write(k + " ");
              k++;
            }
            while (k <= end);
            Console.WriteLine("\nKoniec pętli DO-WHILE");
            break;
        }
      }
    }
  }
}