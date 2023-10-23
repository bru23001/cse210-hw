public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string StandardDetails()
    {
        return $"{_title} - {_description} on {_date.ToShortDateString()} at {_time} located at {_address}.";
    }

    public abstract string FullDetails();

    public virtual string ShortDescription()
    {
        return $"{GetType().Name}: {_title} on {_date.ToShortDateString()}.";
    }
}