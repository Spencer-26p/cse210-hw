using System.Reflection.PortableExecutable;
using System.Transactions;

class Video
{
    private string _author;
    private string _title;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string author, string title, int length, Comment comment1, Comment comment2, Comment comment3, Comment comment4)
    {
        _author = author;
        _title = title;
        _length = length;
        _comments.Add(comment1);
        _comments.Add(comment2);
        _comments.Add(comment3);
        _comments.Add(comment4);
    }
    private int GetNumberComments()
    {
        return _comments.Count;
    }
    public void GetVideoInformation()
    {
        Console.WriteLine($"Title: {_title}; Author: {_author}; Length: {_length} seconds; Number of Comments: {GetNumberComments()}");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}