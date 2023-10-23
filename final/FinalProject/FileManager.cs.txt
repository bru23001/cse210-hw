/*
FileManager Class: This class manages file I/O operations. It has methods for 
loading data from a file and saving data to a file.

*/


using System.Collections.Generic;
using System.IO;

// Class for managing file I/O
public class FileManager
{
    private readonly string _filePath;

    public FileManager(string filePath)
    {
        _filePath = filePath;
    }

    // Load data from file
    public List<Item> LoadData()
    {
        List<Item> items = new List<Item>();
        if (System.IO.File.Exists(_filePath))
        {
            string[] lines = System.IO.File.ReadAllLines(_filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                Item item = new ConcreteItem
                {
                    Id = int.Parse(parts[0]),
                    Name = parts[1],
                    Quantity = int.Parse(parts[2]),
                    Barcode = parts[3],
                    ExpirationDate = DateTime.Parse(parts[4]),
                    Price = double.Parse(parts[5]),
                    GroceryStore = parts[6],
                    Season = parts[7]
                };
                items.Add(item);
            }
        }
        return items;
    }

    // Save data to file
    public void SaveData(List<Item> items)
    {
        List<string> lines = new List<string>();
        foreach (Item item in items)
        {
            string line = $"{item.Id},{item.Name},{item.Quantity},{item.Barcode},{item.ExpirationDate},{item.Price},{item.GroceryStore},{item.Season}";
            lines.Add(line);
        }
        System.IO.File.WriteAllLines(_filePath, lines);
    }
}
