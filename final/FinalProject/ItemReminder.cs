/*
This class will set reminders about items getting close to their expiration dates. Properties: 
Reminder. Method: 1. ExpirationReminder()
*/

class ItemReminder 
{
    public bool Reminder { get; set; }
    private ItemManager _itemManager;
    public ItemReminder(ItemManager itemManager)
    {
        _itemManager = itemManager;
    }
    public void ExpirationReminder(Item item)
    {
        int days = 30;
        if (_itemManager.IsExpiring(days).Contains(item))
        {
            Reminder = true;
            Console.WriteLine($"Reminder: {item.Name} is expiring.");
        }
        else if (item.ExpirationDate < DateTime.Now.AddDays(7))
        {
            Reminder = true;
            Console.WriteLine($"Reminder: {item.Name} is about to expire.");
        }
        else
        {
            Reminder = false;
        }
    }
}
