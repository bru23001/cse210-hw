/*
🙄 RESPONSABILITY: Keeps track of the book, chapter, and verse information.

🙄 BEHAVIORS: have the ability to get the display text of the reference, which is just a string 
combining the book, chapter, and verse (or verses). You could consider having getters and setters 
for each of the data elements that this class stores, but it may be even better to use a constructor 
to set them. The constructor will be discussed in more detail below. 

🙄 METHODS: 
○ GetDisplayText() : string
○ Possible getters and setters

🙄 ATTRIBUTES: The Reference class will need to store a variable for the book (string), the chapter 
(int), and the verse (int). Then, it will also need to store one additional variable for second, or 
"end," verse of the range to handle the case of Proverbs 3:5-6.
○ _book : string
○ _chapter : int
○ _verse : int
○ _endVerse : int

🙄 CONSTRUCTORS: A class for a Reference should have two different constructors to account for cases 
where there is a single verse or multiple verses. Notice that you can have two different constructors 
as long as the parameter list is different. The first constructor would just receive a book, chapter, 
and verse, whereas the second would receive a book, chapter, start verse and end verse. (This ability 
to have multiple versions of a function, as long as the parameters are different is called Function 
Overloading, and it is possible with any function not just constructors.)

Reference(book:string, chapter:int, verse:int)
Reference(book:string, chapter:int, verse:int, endVerse:int)
*/

using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }     
    
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }     

    public string GetDisplayText()
        {
            if (_verse == _endVerse)
            {
                return $"{_book} {_chapter}:{_verse}";
            }
            else
            {
                return $"{_book} {_chapter}:{_verse}-{_endVerse}";
            }
        }
    
}


