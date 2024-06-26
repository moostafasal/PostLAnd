using AutoMapper;
using Postland.Application.featuers.Posts.Commands.CeratePost;
using Postland.Application.featuers.Posts.Commands.DeletPost;
using Postland.Application.featuers.Posts.Commands.UpdatePost;
using Postland.Application.featuers.Posts.Queries.GetPostsDetil;
using Postland.Application.featuers.Posts.Queries.GetPostsList;
using PostLAndDomin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postland.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Post, GetPostListViewModel>().ReverseMap();
            CreateMap<Post, GetPostViewModel>().ReverseMap();
            CreateMap<Post, CreatePostCommand>().ReverseMap();
          
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Post, UpdatePostCommand>().ReverseMap();
            CreateMap<Post, DeletePostCommand>().ReverseMap();


        }

    }
}
