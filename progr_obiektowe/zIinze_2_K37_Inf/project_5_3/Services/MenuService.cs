using project_5.Models.Interfaces;
namespace project_5.Services;

public static class MenuService
{
    public static string ExitProgram()
    {
        Console.WriteLine("Zamknięcie programu");
        Environment.Exit(0);
        return string.Empty;
    }

    public static string ExecuteWork(List<IPrintable> list)
    {
        Console.WriteLine("\n=== Praca ===");
        foreach (var obj in list)
        {
            if (obj is IWorkable w)
            {
                w.DoWork();
            }
        }
        return "Wszystkie zadania wykonane";
    }

    public static string PrintDetails(List<IPrintable> list)
    {
        Console.WriteLine("\n=== Szczegóły obiektów ===");
        foreach (var obj in list)
        {
            Console.WriteLine(obj.GetDetails());
        }
        return "Wyświetlono szczegóły wszystkich obiektów";
    }

    public static string PrintAll(List<IPrintable> list)
    {
        Console.WriteLine("\n=== Lista obiektów ===");
        foreach (var obj in list)
        {
            obj.PrintInfo();
        }

        return "Wyświetlono wszystkie obiekty";
    }
}