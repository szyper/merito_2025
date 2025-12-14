namespace _7_zdarzenia
{
    public delegate void MessageHandler(string message, int priority);

    public class Publisher
    {
        public event MessageHandler MessageEvent;
        public event MessageHandler HighPriorityMessageEvent;

        public void SendMessage(string message, int priority)
        {
            if (MessageEvent != null)
            {
                MessageEvent(message, priority);
            }
            else
            {
                Console.WriteLine("\nBrak subskrybentów. Wiadomość nie została wysłana");
                Console.WriteLine(
                    $"Szczegóły: metoda SendMessage. Treść wiadomości \"{message}\". Priorytet wiadomości: {priority}");
                Console.WriteLine("Powód: brak zarejestrowanych subskrybentów do odbioru wiadomości\n");
            }

            if (priority == 5 && HighPriorityMessageEvent != null)
            {
                HighPriorityMessageEvent(message, priority);
            }
            else
            {
                Console.WriteLine("Brak subskrybentów");
            }
            
        }
    }

    public class Subscriber
    {
        public int Threshold { get; set; }
        public string Name { get; set; }

        public Subscriber(int threshold, string name)
        {
            Threshold = threshold;
            Name = name;
        }
        public void OnMessageReceived(string message, int priority)
        {
            if (priority <= Threshold)
            {
                Console.WriteLine($"{Name} otrzymał wiadomość: {message} [priorytet: {priority}]");
            }
            else
            {
                Console.WriteLine($"{Name} nie otrzymał wiadomości: {message}, o priorytecie: {priority}, ponieważ jest zbyt wysoki dla jego progu");
            }
        }

        public void OnHighPriorityMessageReceived(string message, int priority)
        {
            if (priority == 5 && priority >= Threshold)
            {
                Console.WriteLine($"{Name} otrzymał wiadomość o wysokim priorytecie 5: {message}");
            }
            else
            {
                Console.WriteLine($"{Name} zignorował wiadomość o priorytecie {priority}, ponieważ jego próg jest za niski");
            }
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();
            Subscriber sub1 = new Subscriber(3, "Subskrybent 1");
            Subscriber sub2 = new Subscriber(5, "Subskrybent 2");

            pub.MessageEvent += sub1.OnMessageReceived;
            pub.MessageEvent += sub2.OnMessageReceived;
            
            pub.SendMessage("Pierwsza wiadomość", 1);
            pub.SendMessage("Druga wiadomość", 2);
            pub.SendMessage("Trzecia wiadomość", 3);
            pub.SendMessage("Czwarta wiadomość", 4);
            pub.SendMessage("Piąta wiadomość", 5);

            pub.MessageEvent += sub1.OnHighPriorityMessageReceived;
            pub.MessageEvent += sub2.OnHighPriorityMessageReceived;
            
            pub.SendMessage("Wiadomość o najwyższym priorytecie", 5);
            
            pub.MessageEvent -= sub1.OnMessageReceived;
            
            pub.SendMessage("Szósta wiadomość", 2);

            pub.MessageEvent -= sub2.OnMessageReceived;
            pub.SendMessage("Siódma wiadomość", 2);

        }
    }
}
