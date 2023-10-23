/*
Item Class: This is an abstract class with properties like Id, Name, Quantity, 
Barcode, ExpirationDate, Price, GroceryStore, and Season. It also has an abstract 
method DisplayDetails() which needs to be implemented in any non-abstract class 
that inherits from this Item class.

Properties: These are characteristics of an item, such as its ID, name, quantity, 
barcode, expiration date, price, grocery store, and season. They are all declared 
as public, which means they can be accessed and modified from anywhere in the code.

Abstract Method: The DisplayDetails() method is declared as abstract. This means 
that this method must be overridden in any class that directly inherits from Item. 
The implementation of this method will be specific to the child classes.
*/


using System;
using System.Collections.Generic;

// Base class for all items
public abstract class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public string Barcode { get; set; }
    public DateTime ExpirationDate { get; set; }
    public double Price { get; set; }
    public string GroceryStore { get; set; }
    public string Season { get; set; }

    public int UsageCount { get; set; } // Add this line

    // Abstract method for displaying item details
    public abstract void DisplayDetails(string item);


    

}



