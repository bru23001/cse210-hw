using System;
using System.Collections.Generic;

// Base Activity class
class Activity
{
    protected DateTime _date;
    protected int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
public virtual double GetDistance()
    {
        return 0; // Base class does not have a distance
    }

    public virtual double GetSpeed()
    {
        return 0; // Base class does not have a speed
    }

    public virtual double GetPace()
    {
        return 0; // Base class does not have a pace
    }

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} - {GetType().Name} ({_minutes} min) ";
    }
}
