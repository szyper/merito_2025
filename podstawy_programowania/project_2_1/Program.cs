




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
          ShowMessage("Do widzenia! Program zakończony", "success");
          break;
        }

        //Console.Write("Podaj wartość początkową: ");
        //int start = int.Parse(Console.ReadLine());
        //Console.Write("Podaj wartość końcową: ");
        //int end = int.Parse(Console.ReadLine());

        int start = ReadIntFromUser("Podaj wartość początkową (start): ");
        int end = ReadIntFromUser("Podaj wartość końcową (end): ");

        if (start > end)
        {
          ShowMessage("Błąd: wartość początkowa musi byćmniejsza lub równa końcowej", "error");
          continue;
        }

        switch (choice)
        {
          case "1":
            RunForLoop(start, end);
            ShowMessage("Pętla for zakończona", "success");
            break;

          case "2":
            RunWhileLoop(start, end);
            ShowMessage("Pętla while zakończona", "success");
            break;

          case "3":
            RunDoWhileLoop(start, end);
            ShowMessage("Pętla do-while zakończona", "success");
            break;
          default:
            ShowMessage("Niepoprawny wybór!", "error");
            break;
        }
      }

      Console.WriteLine(new string('-', 40) + "\n");
    }

    private static void ShowMessage(string message, string type = "info")
    {
      ConsoleColor originalColor = Console.ForegroundColor; // kolor domyślny => gray

      switch (type.ToLower())
      {
        case "success":
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("SUKCES: " + message);
          break;

        case "error":
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("BŁĄD: " + message);
          break;

        case "warning":
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine("OSTRZEŻENIE: " + message);
          break;

        default:
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine(message);
          break;
      }

      Console.ForegroundColor = originalColor;
    }

    private static int ReadIntFromUser(string prompt)
    {
      while (true)
      {
        Console.Write(prompt);
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out int value) && value >= 1 && value <= 1000)
        {
          return value;
        }
        ShowMessage("Wpisz poprawną liczbę całkowitą od 1 do 1000", "error");
      }
    }

    private static void RunDoWhileLoop(int start, int end)
    {
      Console.WriteLine($"Pętla DO-WHILE - liczby od {start} do {end}");
      int k = start;
      do
      {
        Console.Write(k + " ");
        k++;
      }
      while (k <= end);
      Console.WriteLine("\nKoniec pętli DO-WHILE");
      ShowMessage("Pętla for wykonana pomyślnie", "success");
    }

    private static void RunWhileLoop(int start, int end)
    {
      Console.WriteLine($"Pętla WHILE - liczby od {start} do {end}");
      int j = start;
      while (j <= end)
      {
        Console.Write(j + " ");
        j++;
      }
      Console.WriteLine("\nKoniec pętli WHILE");
    }

    private static void RunForLoop(int start, int end)
    {
      Console.WriteLine($"Pętla FOR - liczby od {start} do {end}");
      for (int i = start; i <= end; i++)
      {
        Console.Write(i + " ");
      }
      Console.WriteLine("\nKoniec pętli FOR");
    }
  }
}