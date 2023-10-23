/*
ItemFilter Class: This class has methods for filtering items by different criteria such 
as expiration date, quantity, usage count, and price.

FilterExpiring Method: This method filters the items that are expiring within a certain 
number of days. It uses the Where LINQ method to filter the items whose ExpirationDate is 
within the specified number of days from the current date.

FilterByQuantity Method: This method filters the items that have a quantity greater than 
or equal to a certain value. It uses the Where LINQ method to filter the items based on 
their Quantity.

FilterByMostUsed and FilterByLessUsed Methods: These methods filter the items based on 
their usage count. The FilterByMostUsed method orders the items in descending order of 
their UsageCount, while the FilterByLessUsed method orders them in ascending order.

FilterByMostExpensive and FilterByLessExpensive Methods: These methods filter the items 
based on their price. The FilterByMostExpensive method orders the items in descending 
order of their Price, while the FilterByLessExpensive method orders them in ascending order.
*/


using System.Collections.Generic;
using System.Linq;

// Class for filtering items
public class ItemFilter
{
    private ItemManager _itemManager; // Add this line

    public ItemFilter(ItemManager itemManager) // Add a constructor
    {
        _itemManager = itemManager; // Initialize _itemManager
    }
    
    // Filter items by expiration date
    public List<Item> FilterExpiring(List<Item> items, int days)
    {
        return items.Where(item => (item.ExpirationDate - DateTime.Now).Days <= days).ToList();
    }

    // Filter items by quantity
    public List<Item> FilterByQuantity(List<Item> items, int quantity)
    {
        return items.Where(item => item.Quantity >= quantity).ToList();
    }

    // Filter items by most used
    public List<Item> FilterByMostUsed(List<Item> items)
    {
        return items.OrderByDescending(item => item.UsageCount).ToList();
    }

    // Filter items by less used
    public List<Item> FilterByLessUsed(List<Item> items)
    {
        return items.OrderBy(item => item.UsageCount).ToList();
    }

    // Filter items by most expensive
    public List<Item> FilterByMostExpensive(List<Item> items)
    {
        return items.OrderByDescending(item => item.Price).ToList();
    }

    // Filter items by less expensive
    public List<Item> FilterByLessExpensive(List<Item> items)
    {
        return items.OrderBy(item => item.Price).ToList();
    }
}