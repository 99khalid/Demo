using MediatR;
using Demo.Domain;
using AutoMapper;
using System.Threading;
using System.Threading.Tasks;
using Demo.Applicatoin.Interfaces;

namespace Demo.Applicatoin.Features.User.Command.update
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, Unit>
    {
        private readonly IUserinterface<Domain.User> _userrepos;
        private readonly IMapper _mapper;

        public UpdateUserHandler(IUserinterface<Domain.User> userrepos, IMapper mapper)
        {
            _userrepos = userrepos;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateUserCommand command, CancellationToken cancellationToken)
        {
            Domain.User user = _mapper.Map<Domain.User>(command);
            await _userrepos.UpdateAsync(user);
            return Unit.Value;
        }
    }
}
