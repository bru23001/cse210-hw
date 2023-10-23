/*
ItemManager Class: This class seems to be correctly implemented. It has dependencies on 
ItemScan, ItemSearch, and PantryManager which are provided via its constructor. It has 
methods for updating the quantity of an item, getting expired items, and getting an item by ID.

The ItemManager class manages instances of other classes (ItemScan, ItemSearch, PantryManager, 
and DetailsDisplay) and provides high-level operations.
*/

// Class for managing items
public class ItemManager
{
    private readonly ItemScan _itemScan;
    private readonly ItemSearch _itemSearch;
    private readonly PantryManager _pantryManager;
    public DetailsDisplay _detailsDisplay {get; set;}

    public ItemManager(ItemScan itemScan, ItemSearch itemSearch, PantryManager pantryManager, DetailsDisplay detailsDisplay)
    {
        _itemScan = itemScan;
        _itemSearch = itemSearch;
        _pantryManager = pantryManager;
        _detailsDisplay = detailsDisplay;
    }

    // Update the quantity of an item
    public void UpdateQuantity(int id, int newQuantity)
    {
        // Search for the item in the pantry
        Item item = _itemSearch.SearchItem(id);
        if (item == null)
        {
            Console.WriteLine("Item not found in the pantry.");
            return;
        }

        // Modify the quantity of the item in the pantry
        _pantryManager.EditItem(item, newQuantity);

        // Save the data in the file
        _pantryManager.SaveData();
    }

    public void DisplayDetails(Item item) // Add this method
    {
        _detailsDisplay.Display("Item Details", new List<Item> { item });
    }

    // Get a list of expired items
    public List<Item> IsExpiring(int days)
    {
        return _itemSearch.FilterExpiring(_itemSearch.Items, days);
    }

    // Get an item by ID
    public Item GetItemById(int id)
    {
        return _itemSearch.SearchItem(id );
    }
}
