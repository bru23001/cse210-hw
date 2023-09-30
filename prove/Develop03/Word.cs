/*
🙄 RESPONSABILITY: Keeps track of a single word and whether it is shown or hidden.

🙄 BEHAVIORS: are to hide and show a word and to check if a word is hidden or not. In addition, 
a Word should have a behavior to get the display text of that word, which would be either the word 
itself (for example, "prayer") or, if the word were hidden, this behavior would return underscores 
(for example, "______").

🙄 METHODS: 			
○ Hide() : void
○ Show() : void
○ IsHidden() : bool
○ GetDisplayText() : string

🙄 ATTRIBUTES: The Word class will need to store the text of the word itself (a string) and a 
variable to indicate whether that word is shown or hidden (a boolean).
○ _text : string
○ _isHidden : bool

🙄 CONSTRUCTORS: This constructor should accept the text of the word to save it as an attribute. 
In addition, the constructor will need to set the initial visibility of the word (whether it is 
shown or hidden). Notice that you should not need to pass in the visibility of the word. It can 
be set to be visible by default.

-Word(text : string)
*/
public class Word
{
    private string _text;
    private bool _isHidden;
    
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
    // Check if _isHidden is true or false
    if (_isHidden)
    {
        // If _isHidden is true, return "_____"
        return "_____";
    }
    else
    {
        // If _isHidden is false, return the value of _text
        return _text;
    }
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}