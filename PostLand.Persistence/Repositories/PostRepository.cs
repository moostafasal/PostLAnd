
using Microsoft.EntityFrameworkCore;
using Postland.Application.contracts;
using PostLAndDomin;

namespace PostLand.Persistence
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(PostDbContext postDbContext) : base(postDbContext)
        {

        }

        public async Task<IReadOnlyList<Post>> getAllPosts(bool includeCategory)
        {
            List<Post> allPosts = new List<Post>();
            allPosts = includeCategory ? await _dbContext.Posts.Include(x => x.Category).ToListAsync() : await _dbContext.Posts.ToListAsync();
            return allPosts;
        }

        public Task<Post> getPostById(Guid postId, Guid catId)
        {
            throw new NotImplementedException();
        }

        public async Task<Post> GetPostByIdAsync(Guid id, bool includeCategory)
        {
            Post Post = new Post();
            Post = includeCategory ? await _dbContext.Posts.Include(x => x.Category).FirstOrDefaultAsync(x => x.PostId == id) : await GetByIdAsync(id);
            return Post;
        }

        public Task<List<Post>> GetPostsByCategoryIdAsync(Guid categoryId)
        {
            throw new NotImplementedException();
        }
    }

}