using System;

public class Address
{
    public string street { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string zip { get; set; }

    public override string ToString()
    {
        return $"{street}, {city}, {state} {zip}";
    }
}
