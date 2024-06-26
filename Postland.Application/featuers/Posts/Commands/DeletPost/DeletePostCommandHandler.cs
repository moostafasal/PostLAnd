using MediatR;
using OpenQA.Selenium;
using Postland.Application.contracts;
using Postland.Application.featuers.Posts.Commands.DeletPost;
using PostLAndDomin;

namespace Postland.Application.Features.Posts.Commands.DeletePost
{
    public class DeletePostCommandHandler : IRequestHandler<DeletePostCommand>
    {
        private readonly IAsyncRepository<Post> _postRepository;

        public DeletePostCommandHandler(IAsyncRepository<Post> postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<Unit> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            var postToDelete = await _postRepository.GetByIdAsync(request.PostId);

            if (postToDelete == null)
            {
                // Optionally handle not found case
                throw new NotFoundException($"Post with ID {request.PostId} not found.");
            }

            await _postRepository.DeleteAsync(postToDelete);

            return Unit.Value;
        }
    }
}
