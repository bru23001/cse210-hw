/*
ItemSorter Class: This class has methods for sorting items by different criteria such as 
expiration date, quantity, usage count, and price.

*/


using System;
using System.Collections.Generic;
using System.Linq;

// Class for sorting items
public class ItemSorter
{
    private ItemManager _itemManager; // Add this line

    public ItemSorter(ItemManager itemManager) // Add a constructor
    {
        _itemManager = itemManager; // Initialize _itemManager
    }
    // Sort items by expiration date
    public List<Item> SortByExpirationDate(List<Item> items)
    {
        return items.OrderBy(item => item.ExpirationDate).ToList();
    }

    // Sort items by quantity
    public List<Item> SortByQuantity(List<Item> items)
    {
        return items.OrderBy(item => item.Quantity).ToList();
    }

    // Sort items by most used
    public List<Item> SortByMostUsed(List<Item> items)
    {
        return items.OrderByDescending(item => item.UsageCount).ToList();
    }

    // Sort items by less used
    public List<Item> SortByLessUsed(List<Item> items)
    {
        return items.OrderBy(item => item.UsageCount).ToList();
    }

    // Sort items by most expensive
    public List<Item> SortByMostExpensive(List<Item> items)
    {
        return items.OrderByDescending(item => item.Price).ToList();
    }

    // Sort items by less expensive
    public List<Item> SortByLessExpensive(List<Item> items)
    {
        return items.OrderBy(item => item.Price).ToList();
    }
}