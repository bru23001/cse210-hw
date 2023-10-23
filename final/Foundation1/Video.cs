public class Video
{
    public string _title { get; set; }
    public string _author { get; set; }
    public int _length { get; set; }  
    private List<Comment> _comments { get; } = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment);
        }

    Console.WriteLine(); 
    }
}