using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postland.Application.featuers.Posts.Commands.DeletPost
{
    public class DeletePostCommand : IRequest
    {
        public Guid PostId { get; set; }
    }
}
