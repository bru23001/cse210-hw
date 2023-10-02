/*
🙄 RESPONSABILITY: Keeps track of both the reference and the text of the scripture. Can hide words and 
get the rendered display of the text.

🙄 BEHAVIORS: are to hide random words and also to get the display text as a string. (The "display 
text" refers to the text with some words shown normally, and some replaced by underscores.) It would 
also be nice to have a behavior to check if the scripture is completely hidden so that you know when 
to end the program.

🙄 METHODS: 
○ HideRandomWords(numberToHide : int) : void
○ GetDisplayText() : string
○ IsCompletelyHidden() : bool

Which other methods should be called by the Scripture class's HideRandomWords method to help do its 
work?

🙄 ATTRIBUTES: need member variables for a reference and list of all of the words in the scripture.
The data type for the reference is Reference, the custom class defined. The data type for the 
list of words would be List<Word> (notice it is a list of Word objects, rather than a list of strings.)
○ _reference : Reference
○ _words : List<Word>

🙄 CONTRUCTORS: need a constructor that accepts both a reference and the text of the scripture. 
If the Scripture class internally stores a List of Word objects, the first thought would be to pass 
a List<Word> variable to the constructor. While this could work, it would have some downsides. First, 
it would expose the internal storage of the Scripture to the person using the class (losing the 
benefits of encapsulation). Second, it would require the person using the class to do the work of 
splitting their text into the list, the way this class expects it. Not only is this extra work, but 
it also breaks the principle of encapsulation, and will limit your ability to change your class in 
the future.
Instead of passing in a list of words, it would better align with the principle of encapsulation to 
pass in a string that is the text of the scripture. Then, the constructor would have the responsibility
of creating the list, and splitting up the words in the string to create Word objects for each one and 
put them in the list. While including the logic of creating the word list may seem like a lot of work 
for the constructor, it is helpful to encapsulate this logic in the Scripture class so that other code 
does not have to worry about the internal storage of the Scripture. This would enable the program to 
be easily changed in the future, if a different implementation choice were made.

-Scripture(reference : Reference, text : string)
*/
using System;
using System.Linq;
public class Scripture
{
    //OBJECT ATTRIBUTES====================================
    private Reference _reference;
    private List<Word> _words;


    //CONTRUCTOR=====================================
    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }

    //METHODS========================================

    


    public void HideRandomWords(int numberToHide)
    {
        int max = _words.Count;
        int numberToHide = 5;
        //list of indexes of words not hidden
        List<int>notHiddenIndexes = new List<int>();

        //loop through all the words in the list
        

        for (int i = 0; i < max; i++)
        {
            if (!_words[i].IsHidden)
            {
                notHiddenIndexes.Add(i);
            }
        }

        //generate random word indexes and hide that word
        
        while (numberToHide > 0 && notHiddenIndexes.Count > 0)
        {
            int randomIndex = random.Next(notHiddenIndexes.Count);
            int wordIndex = notHiddenIndexes[randomIndex];
            _words[wordIndex].IsHidden = true;
            notHiddenIndexes.RemoveAt(randomIndex);
            numberToHide--;
        }
    }
    
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        List<string>wordTexts = new List<string>();
        foreach (string word in _words)
        {
            wordTexts.Add(word.GetDisplayText()); 
        }
        string allWordsText = "";
        foreach (word in wordTexts)
        {
            allWordsText += wordTexts + "";
        }    
            
        allWordsText=allWordsText.TrimEnd();

        string resultText = referenceText + "\n" + allWordsText;

        return resultText;
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(words => words.IsHidden);
    }

}


