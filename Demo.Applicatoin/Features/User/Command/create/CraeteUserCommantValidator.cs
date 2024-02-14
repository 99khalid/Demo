using FluentValidation;
using Demo.Applicatoin.Features.User.Command.create;

public class CraeteUserCommantValidator : AbstractValidator<CraeteUserCommant>
{
    public CraeteUserCommantValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty()
            .NotNull()
            .MaximumLength(100)
            ;
    }
}