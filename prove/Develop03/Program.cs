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

5. Uses a class called Scripture, another one called Reference and another one called Word.
*/
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("SCRIPTURE MEMORIZER");
        Console.WriteLine();

        
        //ATTRIBUTES========================
        string book = "Abraham";
        int chapter = 3;
        int verse = 22;
        int endVerse = 23;
        string scriptureText = "Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones; And God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast chosen before thou wast born.";
        int numberToHide = 5;

        //create a new instance of Reference class
        Reference reference = new Reference(book, chapter, verse, endVerse);

        Scripture scripture = new Scripture(reference, scriptureText);



        Console.WriteLine (reference.GetDisplayText() );
        Console.WriteLine();
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
        scripture.HideRandomWords(numberToHide);
        Console.Clear();

        }
    }    
}          
