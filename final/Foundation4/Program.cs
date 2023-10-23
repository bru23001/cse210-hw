class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            
            new Running(new DateTime(2022, 11, 3), 30, 4.8),
            new Cycling(new DateTime(2022, 11, 4), 45, 15.5),
            new Swimming(new DateTime(2022, 11, 5), 40, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}