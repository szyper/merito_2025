using project_5.Models;
using project_5.Services;
using project_5.Models.People;
using project_5.Models.Interfaces;


namespace project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunMenu();
        }

        private static void RunMenu()
        {
            List<IPrintable> objects = new List<IPrintable>();

            while (true)
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1. Dodaj osobę");
                Console.WriteLine("2. Dodaj studenta");
                Console.WriteLine("3. Dodaj pracownika");
                Console.WriteLine("4. Wyświetl wszystkie obiekty");
                Console.WriteLine("5. Wyświetl szczegóły wszystkich obiektów");
                Console.WriteLine("6. Wykonaj pracę (DoWork)");
                Console.WriteLine("0. Wyjście");
                Console.Write("Wybór: ");

                int choice = int.Parse(Console.ReadLine());

                _ = choice switch
                {
                    0 => MenuService.ExitProgram(),
                    1 => AddPerson(objects),
                    2 => AddStudent(objects),
                    3 => AddWorker(objects),
                    4 => MenuService.PrintAll(objects),
                    5 => MenuService.PrintDetails(objects),
                    6 => MenuService.ExecuteWork(objects),
                    _ => "Nieprawidłowy wybór. Spróbuj ponownie"
                };
            }
        }

        

        private static string AddWorker(List<IPrintable> list)
        {
            Console.Write("Imię: ");
            string name = Console.ReadLine();
            Console.Write("Wiek: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Zawód: ");
            string profession = Console.ReadLine();

            list.Add(new Worker(name, age, profession));
            return $"Dodano pracownika: {name}";
        }

        private static string AddStudent(List<IPrintable> list)
        {
            Console.Write("Imię: ");
            string name = Console.ReadLine();
            Console.Write("Wiek: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Uczelnia: ");
            string university = Console.ReadLine();

            list.Add(new Student(name, age, university));
            return $"Dodano studenta: {name}";
        }

        private static string AddPerson(List<IPrintable> list)
        {
            Console.Write("Imię: ");
            string name = Console.ReadLine();
            Console.Write("Wiek: ");
            int age = int.Parse(Console.ReadLine());
                        
            list.Add(new Person(name, age));
            return $"Dodano osobę: {name}";
        }
    }
}
