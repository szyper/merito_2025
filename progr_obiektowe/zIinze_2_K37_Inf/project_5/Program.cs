namespace project_5
{
    public interface IPrintable
    {
        void PrintInfo();
    }

    public class Person : IPrintable
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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj imię: ");
            string name = Console.ReadLine();

            Console.Write("Podaj wiek: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Czy chcesz utworzyć studenta? (t/n): ");
            string choice = Console.ReadLine();

            IPrintable entity;

            if (choice.ToLower() == "t")
            {
                Console.Write("Podaj nazwę uczelni: ");
                string university = Console.ReadLine();

                entity = new Student(name, age, university);
            }
            else
            {
                entity = new Person(name, age);
            }

            Console.WriteLine("=== dane obiektu ===");
            entity.PrintInfo();
        }
    }
}
