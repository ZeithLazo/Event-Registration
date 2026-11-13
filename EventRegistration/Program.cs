using BusinessLogicEvent;
namespace EventRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Event Registration System \n");
            bool isRunning = true;

            String choice;
            
            while(isRunning != false) { 
            Console.WriteLine("Choose the number of the event");
            List<string> eventList = Methods.TicketService.GetEvents();
                for (int i = 0; i < eventList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {eventList[i]}");
                }

            choice = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine(choice);

            string date = DateTime.Now.ToString("dd/MM/yyyy");

            Methods.TicketService.EventChoice(choice);  

            Methods.TicketService.TicketInfo(choice, date);

                Console.WriteLine("Register another event? 1 for Yes 2 for No");
                string response = Console.ReadLine();

                if (response == "2") {
                    isRunning = false;
                }

            }
        }
    }
}
