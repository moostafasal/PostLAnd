using FluentValidation;

namespace Postland.Application.featuers.Posts.Commands.CeratePost
{
    public class CreatePostCommandValidator : AbstractValidator<CreatePostCommand>
    {
        public CreatePostCommandValidator()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Content).NotEmpty();
            RuleFor(x => x.CategoryId).NotEmpty().GreaterThan(0);
        }
    }
}
