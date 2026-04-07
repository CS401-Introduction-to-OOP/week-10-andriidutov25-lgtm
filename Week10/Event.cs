namespace Week10;

public class Event
{
    public int NumberOFmove { get; set; }
    public string Description { get; }
    public string Type { get; }
    public string Change { get; set; }

    public Event(int numberOFmove, string description, string type, string change)
    {
        NumberOFmove = numberOFmove;
        Description = description;
        Type = type;
        Change = change;
    }
}