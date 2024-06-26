using PostLAndDomin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postland.Application.contracts
{
    public interface IPostRepository : IAsyncRepository<Post>
    {
        Task<List<Post>> GetPostsByCategoryIdAsync(Guid categoryId);
        //get all posts asyn
        Task<IReadOnlyList<Post>> getAllPosts(bool incloudcategory);

        Task<Post> getPostById(Guid postId , Guid catId);


    }
}
