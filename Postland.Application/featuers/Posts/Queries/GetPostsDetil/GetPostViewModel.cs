using Postland.Application.featuers.Posts.Queries.GetPostsList;
using PostLAndDomin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postland.Application.featuers.Posts.Queries.GetPostsDetil
{
    public class GetPostViewModel
    {
        public Guid PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public CategoryDto Category { get; set; }




    }
}

