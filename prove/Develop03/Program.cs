using System;

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



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
    }
}