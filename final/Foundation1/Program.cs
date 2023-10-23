public class Program
{
    public static void Main()
    {
        // Create some videos
        Video video1 = new Video("Title1", "Author1", 120);
        video1.AddComment(new Comment("User1", "Nice video!"));
        video1.AddComment(new Comment("User2", "I learned a lot."));
        video1.AddComment(new Comment("User3", "Thanks for sharing!"));

        Video video2 = new Video("Title2", "Author2", 150);
        video2.AddComment(new Comment("UserA", "Very insightful."));
        video2.AddComment(new Comment("UserB", "Keep it up!"));

        Video video3 = new Video("Title3", "Author3", 180);
        video3.AddComment(new Comment("UserX", "Amazing content."));
        video3.AddComment(new Comment("UserY", "Subscribed!"));
        video3.AddComment(new Comment("UserZ", "Looking forward to more!"));

        List<Video> videoList = new List<Video> { video1, video2, video3 };

        foreach (Video video in videoList)
        {
            video.DisplayVideoInfo();
        }
    }
}