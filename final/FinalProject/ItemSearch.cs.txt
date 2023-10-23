/*
This class will sort, filter, and search for items in the pantry. It will need a method to sort, 
filter and search the items by expiration date, quantity, most used, less used, more expensive, 
less expensive. Methods: 1. SortItems(), 2. FilterItems(), 3. SearchItems().

ItemSearch Class: This class has a dependency on FileManager which is provided via its constructor. 
It has methods for searching an item by ID, filtering items by expiration date, and loading data 
from a file.
*/



// Class for searching for items
public class ItemSearch
{
    private readonly FileManager _fileManager;

    public List<Item> Items { get; private set; }

    public ItemSearch(FileManager fileManager)
    {
        _fileManager = fileManager;
        Items = LoadData();
    }

    // Search for an item by ID
    public Item SearchItem(int id)
    {
        return Items.FirstOrDefault(item => item.Id == id);
    }

    // Filter items by expiration date
    public List<Item> FilterExpiring(List<Item> items, int days)
    {
        return items.Where(item => (item.ExpirationDate - DateTime.Now).Days <= days).ToList();
    }

    // Load data from file
    private List<Item> LoadData()
    {
        return _fileManager.LoadData();
    }
}
