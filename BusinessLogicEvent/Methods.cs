using DataLayerEvent;

namespace BusinessLogicEvent
{
    public class Methods
    {
        public static class TicketService
        {
            public static string EventChoice(string choice)
            {
                List<string> events = EventData.GetEvents();

                if (choice == "1")
                {
                    return events[0];
                }
                else if (choice == "2")
                {
                    return events[1];
                }
                else if (choice == "3")
                {
                    return events[2];
                }
                else
                {
                    return "";
                }
            }
            public static List<string> GetEvents()
            {
                return EventData.GetEvents();
            }

            public static string TicketInfo(string eventName, string date)
            {
                return "-------------------------------------\r\n" +
                       "----------TICKET-INFORMATION---------\r\n" +
                       "-------------------------------------\r\n" +
                       "--EVENT-REGISTERED: " + eventName + "\r\n" +
                       "--DATE-REGISTERED: " + date + "\r\n" +
                       "-------------------------------------";
            }
        }
    }
}