using AutoMapper;
using MediatR;
using Postland.Application.contracts;
using Postland.Application.featuers.Posts.Queries.GetPostsDetil;
using PostLAndDomin;

namespace Postland.Application.Features.Posts.Queries.GetPostsDetail
{
    public class GetPostsDetailQueryHandler : IRequestHandler<GetPostsDetailQuery, GetPostViewModel>
    {
        private readonly IAsyncRepository<Post> _postRepository;
        private readonly IMapper _mapper;

        public GetPostsDetailQueryHandler(IAsyncRepository<Post> postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<GetPostViewModel> Handle(GetPostsDetailQuery request, CancellationToken cancellationToken)
        {
            var post = await _postRepository.GetByIdAsync(request.PostId);

        

            var postViewModel = _mapper.Map<GetPostViewModel>(post);

            return postViewModel;
        }
    }
}
