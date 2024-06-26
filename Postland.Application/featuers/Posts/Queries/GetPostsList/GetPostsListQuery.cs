using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postland.Application.featuers.Posts.Queries.GetPostsList
{
    public class GetPostsListQuery : IRequest<List<GetPostListViewModel>>
    {
        // Optionally, add properties if needed
    }
}
