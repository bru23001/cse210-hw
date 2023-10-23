// Program class for displaying the main menu and calling appropriate methods
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("1. Items");
            Console.WriteLine("2. Pantry Manager");
            Console.WriteLine("3. Recipes");
            Console.WriteLine("4. Meal Plan");
            Console.WriteLine("5. Shopping list");
            Console.Write("Enter your choice: ");

            try
            {
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ItemsMenu();
                        break;

                    case 2:
                        PantryManagerMenu();
                        break;

                    case 3:
                        RecipeMenu();
                        break;

                    case 4:
                        MealPlanMenu();
                        break;

                    case 5:
                        ShoppingListMenu();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    static void ItemsMenu()
    {
        while (true)
        {
            Console.WriteLine("Items Menu:");
            Console.WriteLine("1. Item Manager");
            Console.WriteLine("2. Item Search");
            Console.WriteLine("3. Item Scan");
            Console.Write("Enter your choice: ");

            try
            {
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ItemManagerMenu();
                        break;

                    case 2:
                        ItemSearchMenu();
                        break;

                    case 3:
                        ItemScanMenu();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    static void ItemManagerMenu()
    {
        FileManager fileManager = new FileManager("items.txt");
        ItemScan itemScan = new ItemScan();
        ItemSearch itemSearch = new ItemSearch(fileManager);
        PantryManager pantryManager = new PantryManager(fileManager);
        DetailsDisplay detailsDisplay = new DetailsDisplay();
        ItemManager itemManager = new ItemManager(itemScan, itemSearch, pantryManager);

        while (true)
        {
            Console.WriteLine("Item Manager Menu:");
            Console.WriteLine("1. Update Quantity");
            Console.WriteLine("2. Expires");
            Console.WriteLine("3. Display Details");
            Console.Write("Enter your choice: ");

            try
            {
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the item ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter the new quantity: ");
                        int quantity = int.Parse(Console.ReadLine());
                        itemManager.UpdateQuantity(id, quantity);
                        break;

                    case 2:
                        Console.Write("Enter the number of days until expiration: ");
                        int days = int.Parse(Console.ReadLine());
                        List<Item> expiredItems = itemManager.GetExpiredItems(days);
                        Console.WriteLine($"Expired items within {days} days:");
                        detailsDisplay.Display("Expired Items:", expiredItems);
                        break;

                    case 3:
                        Console.Write("Enter the item ID: ");
                        int id2 = int.Parse(Console.ReadLine());
                        Item item = itemManager.GetItemById(id2);
                        if (item != null)
                        {
                            item.DisplayDetails();
                        }
                        else
                        {
                            Console.WriteLine("Item not found.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    static void ItemSearchMenu()
    {
        FileManager fileManager = new FileManager("items.txt");
        ItemSearch itemSearch = new ItemSearch(fileManager);
        DetailsDisplay detailsDisplay = new DetailsDisplay();
        ItemSorter itemSorter = new ItemSorter();
        ItemFilter itemFilter = new ItemFilter();

        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Sort Items");
        Console.WriteLine("2. Filter Items");
        Console.WriteLine("3. Search Items");
        Console.Write("Enter your choice: ");

        try
        {
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Select a sort option:");
                    Console.WriteLine("1. Expiring");
                    Console.WriteLine("2. Quantity");
                    Console.WriteLine("3. Most Used");
                    Console.WriteLine("4. Less Used");
                    Console.WriteLine("5. Most Expensive");
                    Console.WriteLine("6. Less Expensive");
                    Console.Write("Enter your choice: ");
                    int sortOption = int.Parse(Console.ReadLine());

                    List<Item> sortedItems = new List<Item>();
                    switch (sortOption)
                    {
                        case 1:
                            sortedItems = itemSorter.SortByExpirationDate(itemSearch.Items);
                            break;
                        case 2:
                            sortedItems = itemSorter.SortByQuantity(itemSearch.Items);
                            break;
                        case 3:
                            sortedItems = itemSorter.SortByMostUsed(itemSearch.Items);
                            break;
                        case 4:
                            sortedItems = itemSorter.SortByLessUsed(itemSearch.Items);
                            break;
                        case 5:
                            sortedItems = itemSorter.SortByMostExpensive(itemSearch.Items);
                            break;
                        case 6:
                            sortedItems = itemSorter.SortByLessExpensive(itemSearch.Items);
                            break;
                        default:
                            Console.WriteLine("Invalid sort option.");
                            break;
                    }

                    if (sortedItems.Count > 0)
                    {
                        Console.WriteLine("Sorted items:");
                        detailsDisplay.Display("Sorted Items:", sortedItems);
                    }
                    else
                    {
                        Console.WriteLine("No items found.");
                    }
                    break;

                case 2:
                    Console.WriteLine("Select a filter option:");
                    Console.WriteLine("1. Expiring");
                    Console.WriteLine("2. Quantity");
                    Console.WriteLine("3. Most Used");
                    Console.WriteLine("4. Less Used");
                    Console.WriteLine("5. Most Expensive");
                    Console.WriteLine("6. Less Expensive");
                    Console.Write("Enter your choice: ");
                    int filterOption = int.Parse(Console.ReadLine());

                    List<Item> filteredItems = new List<Item>();
                    switch (filterOption)
                    {
                        case 1:
                            Console.WriteLine("Enter number of days until expiration:");
                            int days = int.Parse(Console.ReadLine());
                            filteredItems = itemFilter.FilterExpiring(itemSearch.Items, days);
                            break;
                        case 2:
                            Console.WriteLine("Enter minimum quantity:");
                            int quantity = int.Parse(Console.ReadLine());
                            filteredItems = itemFilter.FilterByQuantity(itemSearch.Items, quantity);
                            break;
                        case 3:
                            filteredItems = itemFilter.FilterByMostUsed(itemSearch.Items);
                            break;
                        case 4:
                            filteredItems = itemFilter.FilterByLessUsed(itemSearch.Items);
                            break;
                        case 5:
                            filteredItems = itemFilter.FilterByMostExpensive(itemSearch.Items);
                            break;
                        case 6:
                            filteredItems = itemFilter.FilterByLessExpensive(itemSearch.Items);
                            break;
                        default:
                            Console.WriteLine("Invalid filter option.");
                            break;
                    }

                    if (filteredItems.Count > 0)
                    {
                        Console.WriteLine("Filtered items:");
                        detailsDisplay.Display("Filtered Items:", filteredItems);
                    }
                    else
                    {
                        Console.WriteLine("No items found.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Enter search keyword:");
                    string keyword = Console.ReadLine();
                    List<Item> searchResults = itemSearch.SearchItems(itemSearch.Items, keyword);

                    if (searchResults.Count > 0)
                    {
                        Console.WriteLine($"Search results for '{keyword}':");
                        detailsDisplay.Display("Search Results:", searchResults);
                    }
                    else
                    {
                        Console.WriteLine($"No items found for '{keyword}'.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}