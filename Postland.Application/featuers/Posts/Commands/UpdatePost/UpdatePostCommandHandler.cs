using AutoMapper;
using MediatR;
using OpenQA.Selenium;
using Postland.Application.contracts;
using Postland.Application.featuers.Posts.Commands.UpdatePost;
using PostLAndDomin;


namespace Postland.Application.Features.Posts.Commands.UpdatePost
{
    public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand>
    {
        private readonly IAsyncRepository<Post> _postRepository;
        private readonly IMapper _mapper;

        public UpdatePostCommandHandler(IAsyncRepository<Post> postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            var postToUpdate = await _postRepository.GetByIdAsync(request.PostId);

            if (postToUpdate == null)
            {
                // Optionally handle not found case
                throw new NotFoundException($"Post with ID {request.PostId} not found.");
            }
            Post post = _mapper.Map<Post>(postToUpdate);
   

            await _postRepository.UpdateAsync(post);

            return Unit.Value;
        }
    }
}
