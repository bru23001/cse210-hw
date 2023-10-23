using System;
using System.Collections.Generic;
using System.Transactions;

public class Comment
{
    public string _name { get; set; }  // Name of the person who commented
    public string _text { get; set; }  // Comment text

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public override string ToString()
    {
        return $"{_name} said: {_text}";
    }

    
}