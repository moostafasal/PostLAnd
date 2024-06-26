using MediatR;
using Postland.Application.featuers.Posts.Queries.GetPostsList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postland.Application.featuers.Posts.Queries.GetPostsDetil
{
    public class GetPostsDetailQuery : IRequest<GetPostViewModel>
    {
        public Guid PostId { get; set; }
    }
}
