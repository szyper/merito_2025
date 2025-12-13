


namespace _4_listy
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<int> list = new List<int>();
      bool exit = false;

      while (!exit)
      {
        DisplayMenu();
        Console.Write("Twój wybór: ");
        //int choice = int.Parse(Console.ReadLine());
        int choice = ReadInt("Twój wybór: ");


        switch (choice)
        {
          case 1:
            AddElement(list);
            break;
          case 2:
            AddRandomElements(list);
            break;
          case 3:
            RemoveElement(list);
            break;
          case 4:
            DisplayList(list);
            break;
          case 5:
            SortListAscending(list);
            break;
          case 6:
            SortListDescending(list);
            break;
          case 7:
            ClearList(list);
            break;
          case 8:
            exit = true;
            break;
          default:
            Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie");
            break;


        }
      }
    }

    private static int ReadInt(string message)
    {
      int value;
      while (true)
      {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out value))
          return value;

        Console.WriteLine("Błąd! Podaj poprawną liczbę");
      }
    }

    private static void ClearList(List<int> list)
    {
      list.Clear();
      Console.WriteLine("Lista została wyczyszczona");
    }

    private static void SortListDescending(List<int> list)
    {
      if (list.Count == 0)
      {
        Console.WriteLine("Lista jest pusta. Nie można posortować");
        return;
      }

      list.Sort();
      list.Reverse();
      Console.WriteLine("Lista została posortowana niemalejąco");
    }

    private static void SortListAscending(List<int> list)
    {
      if (list.Count == 0)
      {
        Console.WriteLine("Lista jest pusta. Nie można posortować");
        return;
      }

      list.Sort();
      Console.WriteLine("Lista została posortowana niemalejąco");
    }

    private static void DisplayList(List<int> list)
    {
      if (list.Count == 0)
      {
        Console.WriteLine("Lista jest pusta");
        return;
      }
      Console.WriteLine("\nZawartość listy:");
      foreach (var item in list)
      {
        Console.Write(item + " ");
      }
      Console.WriteLine("\n");
    }

    private static void RemoveElement(List<int> list)
    {
      if (list.Count == 0)
      {
        Console.WriteLine("Lista jest pusta. Nie można usunąć elementu");
        return;
      }
      Console.Write("Podaj indeks elementu do usunięcia: ");
      int index = int.Parse(Console.ReadLine());

      if (index >= 0 && index < list.Count)
      {
        list.RemoveAt(index);
        Console.WriteLine("Element został usunięty");
      }
      else
      {
        Console.WriteLine("Nieprawidłowy indeks");
      }
    }

    private static void AddRandomElements(List<int> list)
    {
      Console.Write("Ile losowych liczb chcesz dodać? ");
      int count = int.Parse(Console.ReadLine());

      Random rand = new Random();

      for (int i = 0; i < count; i++)
      {
        list.Add(rand.Next(1, 101));
      }
      Console.WriteLine($"{count} losowych liczb zostało dodanych do listy");
    }

    private static void AddElement(List<int> list)
    {
      Console.Write("Podaj liczbę do dodania: ");
      int number = int.Parse(Console.ReadLine());
      list.Add(number);
      Console.WriteLine("Element został dodany do listy");
    }

    private static void DisplayMenu()
    {
      Console.WriteLine("Menu:");
      Console.WriteLine("1. Dodaj element listy");
      Console.WriteLine("2. Dodaj losowe elementy do listy");
      Console.WriteLine("3. Usuń element z listy");
      Console.WriteLine("4. Wyświetl listę");
      Console.WriteLine("5. Posortuj listę niemalejąco");
      Console.WriteLine("6. Posortuj listę nierosnąco");
      Console.WriteLine("7. Wyczyść listę");
      Console.WriteLine("8. Wyjdź");
    }
  }
}