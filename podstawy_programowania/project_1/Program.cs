namespace project_1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // zmienne i podstawowe typy
      int age = 25; // liczba calkowita 32-bitowa
      System.Int32 age1 = 25;
      Console.WriteLine(age);

      Console.WriteLine(typeof(int) == typeof(System.Int32));

      double height = 1.85; // liczba zmiennoprzecinkowa (64-bity)
      Console.WriteLine(height); // 1,85
      float weight = 88.5f; // liczba zmiennoprzecinkowa (32-bity)
      decimal m = 3.14159m; // liczba zmiennoprzecinkowa (128-bitów)

      bool isSTudent = true; // wartość logiczna
      char grade = 'A'; // pojedynczy znak
      string name = "Franciszek"; // łańcuch znaków (tekst)

      height = 185.12345;
      // typy bez znaków
      uint counter = 200u; // liczba całkowita bez znaku
      counter = 2;
      ulong bigNumber = 2222222222222222222UL;

      // interpolacja łańcuchów
      string firstName = "Franciszek";
      Console.WriteLine($"Imię: {firstName}");
      Console.WriteLine($"Wzrost: {height:F2}");

      // formatowanie złożone (stara metoda formatowania tekstu)
      string lastName = "Nowak";
      Console.WriteLine("Imię i nazwisko: {0} {1}", firstName, lastName);

      // interpolacja stringów z wyrażeniami
      Console.WriteLine($"Pełnoletnie? {age >= 18}");
      Console.WriteLine($"BMI: {weight / (height * height):F2}");
      Console.WriteLine($"Ocena tekstowo: {(grade == 'A' ? "Celujący" : "Inna")}");

      // kolorowy tekst
      Console.ForegroundColor = ConsoleColor.DarkMagenta;
      Console.WriteLine("Error");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Success");
      Console.ResetColor();

      // instrukcje warunkowe
      if (age >= 18)
      {
        Console.WriteLine("Osoba jest pełnoletnia");
      }
      else
      {
        Console.WriteLine("Osoba jest niepełnoletnia");
      }

      // ternary operator (krótsza wersja)
      Console.WriteLine(age >= 18 ? "Osoba jest pełnoletnia" : "Osoba jest niepełnoletnia");

      // z switch expression
      Console.WriteLine(age switch
      {
        >= 18 => "Osoba jest pełnoletnia",
        _ => "Osoba jest niepełnoletnia"
      }
      );

      // instrukcja switch
      grade = 'B';
      switch (grade)
      {
        case 'A':
          Console.WriteLine("Ocena: celujący");
          break;
        case 'B':
          Console.WriteLine("Ocena: bardzo dobry");
          break;
        default:
          Console.WriteLine("Inna ocena");
          break;
      }

      Console.WriteLine(grade switch
      {
        'A' => "Ocena celująca",
        'B' => "Ocena bardzo dobra",
        _ => "Inna opcja"
      });

      /*
       * skaner pogody
       */

      Console.Write("Podaj temperaturę: ");
      // float temp = Convert.ToSingle(Console.ReadLine());
      double temp = Convert.ToDouble(Console.ReadLine());

      Console.Write("Podaj symbol pogody (S, C, R, N): ");
      char weather = char.ToUpper(Console.ReadLine()![0]);

      // tuple pattern matching
      string advice = (temp, weather) switch
      {
        ( >= 25, 'S') => "Słońce! LAto w pełni",
        ( >= 25, _) => "Ciepło! Delikatne ubranie",
        ( < 0, _) => "Mróz! czapka i szalik",
        (_, 'R') => "Deszcz",
        (_, 'N') => "Śnieg",
        (_, 'C') => "Chmury",
        _ => "Pogoda nieznana"
      };

      Console.ForegroundColor = temp >= 25 ? ConsoleColor.Yellow :
                                temp < 0 ? ConsoleColor.Cyan : ConsoleColor.Gray;

      Console.WriteLine($"\n{advice}");
      Console.ResetColor();
    }
  }
}