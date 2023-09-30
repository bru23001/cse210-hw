/*
1. 😀 What does the program do?: People often try to memorize poems or passages of scripture. 
One of the challenges they encounter is that they want to hide the scripture while they are practicing, 
but they may not be able to recite the whole scripture from memory just yet. To help solve this problem 
so that people can better memorize a scripture, write a program that displays the full scripture and then 
hides a few words at a time until the complete scripture is hidden.

2. 😀 What user inputs does it have?: Prompt the user to press the enter key or type quit. If the user 
types quit, the program should end. If the user presses the enter key (without typing quit), the program 
should hide a few random words in the scripture, clear the console screen, and display the scripture again.

3. 😀 What output does it produce?: Clear the console screen and display the complete scripture, including 
the reference and the text. The program should continue prompting the user and hiding more words until all 
words in the scripture are hidden.  When selecting the random words to hide, for the core requirements, you 
can select any word at random, even if the word was already hidden. (As a stretch challenge, try to randomly 
select from only those words that are not already hidden.)

4. 😀 How does the program end?: When all words in the scripture are hidden, the program should end. If the 
user types quit, the program should end.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        //ATTRIBUTES========================
        string book = "Abraham";
        int chapter = 3;
        int verse = 22;
        int endVerse = 23;
        string scriptureText = "22.Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones; 23.And God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast chosen before thou wast born.";
        string text = "";
        Console.WriteLine("SCRIPTURE MEMORIZER");
        Console.WriteLine();

        //create a reference
        Reference reference = new Reference(book, chapter, verse, endVerse); 
        Scripture text = new Scripture(reference, text);


        // Split the scriptureText string into an array of words
        string[] splitText = scriptureText.Split(' ');

        // Create a new list to hold the Word objects
        List<string> words = new List<string>();

        // Loop through each word in the splitText array
        foreach (string word in splitText)
        {
            // Create a new Word object with the word
            words wordObject = new words(word);

            // Add the Word object to the words list
            words.Add(wordObject);
        }

        Scripture scripture = new Scripture(reference, words);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide a word or type 'quit to exit. ");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            } 
            scripture.HideRandomWords(1);
        }
    }
}

internal class Scripture
{
    public Scripture(Reference reference, Scripture text)
    {
        Reference = reference;
        Text = text;
    }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Text1 = text;
    }

    public Reference Reference { get; }
    public Scripture Text { get; }
    public string Text1 { get; }
}

internal class Reference
{
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = endVerse;
    }

    public string Book { get; }
    public int Chapter { get; }
    public int Verse { get; }
    public int EndVerse { get; }
}