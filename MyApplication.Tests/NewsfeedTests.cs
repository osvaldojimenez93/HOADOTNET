using MyApplication.Client.Models;
namespace MyApplication.Tests;

public class NewsfeedTests
{
    [Fact]
    public void CanCreateNewPost()
    {
        // Arrange
        var newsfeed = new Newsfeed();
        var post = new Post();

        // Act
        newsfeed.AddPost(post);

        // Assert
        Assert.Contains(post, newsfeed.Posts);
    }
}

public class Newsfeed
{
    public List<Post> Posts { get; } = new();
    public void AddPost(Post post) => Posts.Add(post);
}

