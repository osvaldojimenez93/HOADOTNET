namespace MyApplication.Client.Models;

public class Comment
{
    public string UserAvatar { get; set; }
    public string UserName { get; set; }
    public DateTime Timestamp { get; set; }
    public string Content { get; set; }
    public int Likes { get; set; }
    public bool HasLiked { get; set; }
}
