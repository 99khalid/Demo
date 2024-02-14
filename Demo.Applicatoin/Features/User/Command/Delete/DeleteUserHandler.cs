
using MediatR;
using Demo.Domain;
using AutoMapper;
using System.Threading;
using System.Threading.Tasks;
using Demo.Applicatoin.Features.User.Command.Delete;
using Demo.Applicatoin.Interfaces;

namespace Demo.Applicatoin.Features.User.Command.update
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, Unit>
    {
        private readonly IUserinterface<Domain.User> _userrepos;
        private readonly IMapper _mapper;

        public DeleteUserHandler(IUserinterface<Domain.User> userrepos, IMapper mapper)
        {
            _userrepos = userrepos;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteUserCommand command, CancellationToken cancellationToken)
        {
            Domain.User userToUpdate = await _userrepos.GetByIdAsync(command.UserId);

          

            if (command.IsDeleted)
            {
                userToUpdate.IsDeleted = true; 
            }
           
            await _userrepos.UpdateAsync(userToUpdate);

            return Unit.Value;
        }
    }
}
