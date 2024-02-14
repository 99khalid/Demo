using AutoMapper;
using Demo.Applicatoin.Features.Department.Command.Delete;
using Demo.Applicatoin.Features.User.Command.update;
using Demo.Applicatoin.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Applicatoin.Features.Department.Command.Update
{
    public class UpdateDeptCommandHandler : IRequestHandler<UpdateDeptCommand, Unit>
    {
        private readonly IUserinterface<Domain.Department> _department;
        private readonly IMapper _mapper;

        public UpdateDeptCommandHandler(IUserinterface<Domain.Department> department, IMapper mapper)
        {
            _department = department;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateDeptCommand command, CancellationToken cancellationToken)
        {
            Domain.Department user = _mapper.Map<Domain.Department>(command);
            await _department.UpdateAsync(user);
            return Unit.Value;
        }
    }
}
