namespace _6_delegaty
{
    internal class Program
    {
        public delegate float Operation(float x, float y);

        public static float Add(float x, float y)
        {
            return x + y;
        }

        public static float Subtract(float x, float y)
        {
            return x - y;
        }

        public static float Multiply(float x, float y)
        {
            return x * y;
        }

        public static float Divide(float x, float y)
        {
            return x / y;
        }

        public static void DisplayResult(Operation op, float x, float y)
        {
            float result;

            if (op.Method.Name == "Divide" && y == 0)
            {
                Console.WriteLine("Błędne dzielenie przez 0");
                result = 0;
            }
            else
            {
                try
                {
                    result = op(x, y);
                    Console.WriteLine("Wynik operacji {0} na liczbach {1} i {2} wynosi {3}", op.Method.Name, x, y, result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    result = 0;
                }
            }
        }
        
        static void Main(string[] args)
        {
            Dictionary<string, Operation> operations = new Dictionary<string, Operation>()
            {
                { "+", Add },
                { "-", Subtract },
                { "*", Multiply },
                { "/", Divide }
            };
            
            float a = GetFloatFromUser("Podaj pierwszą liczbę: ");
            float b = GetFloatFromUser("Podaj drugą liczbę: ");

            Console.WriteLine("Wybierz operację:");
            Console.WriteLine("+ Dodawanie");
            Console.WriteLine("- Odejmowanie");
            Console.WriteLine("* Mnożenie");
            Console.WriteLine("/ Dzielenie");

            Console.Write("Twój wybór: ");
            string choice = Console.ReadLine();

            if (operations.ContainsKey(choice))
            {
                DisplayResult(operations[choice], a, b);
            }
            else
            {
                Console.WriteLine("Nieznana operacja");
            }

            Console.ReadKey();
            
            /*Operation adding = new Operation(Add);
            Operation subtracting = new Operation(Subtract);
            Operation multiplying = new Operation(Multiply);
            Operation dividing = new Operation(Divide);
            
            DisplayResult(adding, a, b);
            DisplayResult(subtracting, a, b);
            DisplayResult(multiplying, a, b);
            DisplayResult(dividing, a, b);*/

            Console.ReadKey();
        }

        public static float GetFloatFromUser(string prompt)
        {
            Console.Write(prompt);
            float number;

            bool isValid = float.TryParse(Console.ReadLine(), out number) && number >= 0;

            while (!isValid)
            {
                Console.Write("Nieprawidłowe dane. Podaj liczbę zmiennoprzecinkową nieujemną:");
                isValid = float.TryParse(Console.ReadLine(), out number) && number >= 0;
            }
            return number;
        }
    }
}
