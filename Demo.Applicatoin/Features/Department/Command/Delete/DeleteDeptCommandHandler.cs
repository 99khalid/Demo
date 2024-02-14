using AutoMapper;
using Demo.Applicatoin.Features.User.Command.Delete;
using Demo.Applicatoin.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Applicatoin.Features.Department.Command.Delete
{
    public class DeleteDeptCommandHandler:IRequestHandler<DeleteDeptCommand,Unit>
    {
        private readonly IUserinterface<Domain.Department> _department;
        private readonly IMapper _mapper;

        public DeleteDeptCommandHandler(IUserinterface<Domain.Department> department, IMapper mapper)
        {
            _department = department;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteDeptCommand command, CancellationToken cancellationToken)
        {
            Domain.Department userToUpdate = await _department.GetByIdAsync(command.Id);



            if (command.IsDeleted)
            {
                userToUpdate.IsDeleted = true;
            }

            await _department.UpdateAsync(userToUpdate);

            return Unit.Value;
        }
    }
}
