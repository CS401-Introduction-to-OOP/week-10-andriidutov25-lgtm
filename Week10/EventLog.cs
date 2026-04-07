namespace Week10;

public class EventLog
{
    private IEnumerable<Event> EventLogs = new List<Event>();

    public IEnumerable<Event> ShowEventByDateOfadd()
    {
        var enumerate = EventLogs.GetEnumerator();
        while (enumerate.MoveNext())
        {
            yield return enumerate.Current;
        }
    }
    
}