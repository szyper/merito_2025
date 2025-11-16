namespace project_5
{
    public interface IPrintable
    {
        void PrintInfo();
        string GetDetails();
    }

    public interface IWorkable
    {
        void DoWork();
    }

    public class Person : IPrintable, IWorkable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Imię: {Name}, wiek: {Age}");
        }

        public virtual string GetDetails()
        {
            return $"Osoba: {Name}, wiek: {Age}";
        }

        public virtual void DoWork()
        {
            Console.WriteLine($"{Name} idzie do pracy");
        }
    }

    public class Student : Person
    {
        public string University { get; set; }
        
        public Student(string name, int age, string university) : base(name, age)
        {
            University = university;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Imię: {Name}, wiek: {Age}, uczelnia: {University} ");
        }

        public override string GetDetails()
        {
            return $"Student {Name}, {Age} lat, uczelnia: {University}";
        }

        public override void DoWork()
        {
            Console.WriteLine($"{Name} uczy się na studiach");
        }
    }

    public class Worker : Person
    {
        public string Profession { get; set; }

        public Worker(string name, int age, string profession) : base(name, age)
        {
            Profession = profession;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name}, wiek: {Age}, zawód: {Profession}");
        }

        public override string GetDetails()
        {
            return $"Pracownik {Name}, wiek: {Age}, zawód: {Profession}";
        }

        public override void DoWork()
        {
            Console.WriteLine($"{Name} pracuje jako {Profession}");
        }
    }
    
    
    internal class Program
    {
        static void Main(string[] args)
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

                if (choice == 0) break;
                string name;
                int age;
                
                
                switch (choice)
                {
                    case 1:
                        Console.Write("Imię: ");
                        name = Console.ReadLine();
                        Console.Write("Wiek: ");
                        age = int.Parse(Console.ReadLine());
                        
                        objects.Add(new Person(name, age));
                        break;
                    
                    case 2:
                        Console.Write("Imię: ");
                        name = Console.ReadLine();
                        Console.Write("Wiek: ");
                        age = int.Parse(Console.ReadLine());
                        Console.Write("Uczelnia: ");
                        string university = Console.ReadLine();

                        objects.Add(new Student(name, age, university));
                        break;
                    
                    case 3:
                        Console.Write("Imię: ");
                        name = Console.ReadLine();
                        Console.Write("Wiek: ");
                        age = int.Parse(Console.ReadLine());
                        Console.Write("Zawód: ");
                        string profession = Console.ReadLine();

                        objects.Add(new Worker(name, age, profession));
                        break;
                    
                    case 4:
                        Console.WriteLine("\n=== Lista obiektów ===");
                        foreach (var obj in objects)
                        {
                            obj.PrintInfo();
                        }
                        break;
                    
                    case 5:
                        Console.WriteLine("\n=== Szczegóły obiektów ===");
                        foreach (var obj in objects)
                        {
                            Console.WriteLine(obj.GetDetails());
                        }
                        break;
                    
                    case 6:
                        Console.WriteLine("\n=== Praca ===");
                        foreach (var obj in objects)
                        {
                            if (obj is IWorkable w)
                            {
                                w.DoWork();
                            }
                        }
                        break;
                }
            }
        }
    }
}
