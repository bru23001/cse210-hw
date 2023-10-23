/*
This class represents the pantry. This class will have a property that is a collection of 
items, such as a list or a dictionary. It will need methods to perform operations on the pantry, 
such as adding, editing, or deleting items. Methods: 1. AddingItem(), 2. EditItem(), 3. DeleteItem().


*/

// Class for managing the pantry
public class PantryManager
{
    private readonly FileManager _fileManager;

    public List<Item> Items { get; private set; }

    public PantryManager(FileManager fileManager)
    {
        _fileManager = fileManager;
        Items = LoadData();
    }

    // Edit an item in the pantry
    public void EditItem(Item item, int newQuantity)
    {
        item.Quantity = newQuantity;
    }

    // Save data to file
    public void SaveData()
    {
        _fileManager.SaveData(Items);
    }

    // Load data from file
    private List<Item> LoadData()
    {
        return _fileManager.LoadData();
    }
}