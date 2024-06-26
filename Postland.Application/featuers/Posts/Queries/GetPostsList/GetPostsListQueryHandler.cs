using AutoMapper;
using MediatR;
using Postland.Application.contracts;
using Postland.Application.featuers.Posts.Queries.GetPostsList;
using PostLAndDomin;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Postland.Application.Features.Posts.Queries.GetPostsList
{
    public class GetPostsListQueryHandler : IRequestHandler<GetPostsListQuery, List<GetPostListViewModel>>
    {
        private readonly IAsyncRepository<Post> _postRepository;
        private readonly IMapper _mapper;

        public GetPostsListQueryHandler(IAsyncRepository<Post> postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<List<GetPostListViewModel>> Handle(GetPostsListQuery request, CancellationToken cancellationToken)
        {
            var posts = await _postRepository.ListAllAsync();
            var postViewModels = _mapper.Map<List<GetPostListViewModel>>(posts);

            return postViewModels;
        }
    }
}
