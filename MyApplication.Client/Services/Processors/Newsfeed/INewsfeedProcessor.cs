using MyApplication.Client.Models;
namespace MyApplication.Client.Services.Processors.Newsfeed;

public interface INewsfeedProcessor
{
    Task<IEnumerable<Post>> GetPostsAsync();
    Task<Post> GetPostAsync(int id);
    Task<Post> CreatePostAsync(Post post);
    Task<Post> UpdatePostAsync(int id, Post post);
    Task DeletePostAsync(int id);
}
