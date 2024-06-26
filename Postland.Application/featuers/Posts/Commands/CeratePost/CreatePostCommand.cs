using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postland.Application.featuers.Posts.Commands.CeratePost
{
    public class CreatePostCommand : IRequest<Guid>
    {
        public string Title { get; set; }
        public string Content { get; set; }


        public int CategoryId { get; set; }

    }
}
