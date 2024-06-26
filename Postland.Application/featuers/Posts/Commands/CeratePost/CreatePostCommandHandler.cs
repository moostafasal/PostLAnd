using AutoMapper;
using MediatR;
using Postland.Application.contracts;
using Postland.Application.featuers.Posts.Commands.CeratePost;
using PostLAndDomin;

namespace Postland.Application.Features.Posts.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, Guid>
    {
        private readonly IAsyncRepository<Post> _postRepository;
        private readonly IMapper _mapper;

        public CreatePostCommandHandler(IAsyncRepository<Post> postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            CreatePostCommandValidator reqoustvalidator = new CreatePostCommandValidator();
            var result= reqoustvalidator.ValidateAsync(request);

        
            var postEntity = _mapper.Map<Post>(request);

            await _postRepository.AddAsync(postEntity);

            // Optionally, return the ID of the newly created post
            return postEntity.PostId;
        }
    }
}
