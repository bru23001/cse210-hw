/*
DetailsDisplay Class: This class has a method Display that takes a string title and a 
list of Item objects as parameters. It iterates over the list of items and calls the
DisplayDetails() method on each item.

Display Method: This method first prints the title to the console. Then, it iterates 
over the list of items and calls the DisplayDetails() method on each item. This method 
is expected to be implemented in the Item class or its subclasses, as it’s declared as 
an abstract method in the Item class. After displaying the details of all items, it 
prints a new line to the console.

*/


using System.Collections.Generic;

// Class for displaying item details
public class DetailsDisplay
{
    private ItemManager _itemManager; // Add this line

    public DetailsDisplay(ItemManager itemManager) // Add a constructor
    {
        _itemManager = itemManager; // Initialize _itemManager
    }
    public void Display(string title, List<Item> items)
    {
        Console.WriteLine(title);
        foreach (var item in items)
        {
            item.DisplayDetails("keyword");
        }
        Console.WriteLine();
    }
}

