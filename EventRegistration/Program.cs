namespace EventRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Event Registration System \n");

            String events;
            

            Console.WriteLine("Choose the number of the event");
            Console.WriteLine("List Of Events: \n 1. Tech Expo \n 2. Art Exhibit \n 3. Seminar \n");

            events = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine(events);

            string date = DateTime.Now.ToString("dd/MM/yyyy");
            if (events == "1")
            {
                events = "Tech Expo";
                
            }
            else if (events == "2")
            {
                events = "Art Exhibit";
                
            }
            else if (events == "3")
            {
                events = "Seminar";
                
            }
            else
            {
                Console.WriteLine("Invalid event");
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("----------TICKET-INFORMATION---------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("--EVENT-REGISTERED: "+events+"-------");
            Console.WriteLine("--DATE-REGISTERED: "+date+"----------");
            Console.WriteLine("-------------------------------------");




        }
    }
}
