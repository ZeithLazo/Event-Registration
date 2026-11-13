namespace DataLayerEvent
{
    public class EventData
    {
        private static List<string> events = new List<string>() { "Tech Expo", "Art Exhibit", "Seminar" };

        public static List<string> GetEvents()
        {
            return events;
        }
    }
}