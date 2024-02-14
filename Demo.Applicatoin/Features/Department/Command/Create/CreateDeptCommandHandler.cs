using AutoMapper;
using Demo.Applicatoin.Interfaces;
using MediatR;


namespace Demo.Applicatoin.Features.Department.Command.Create
{
    public class CreateDeptCommandHandler : IRequestHandler<CreateDeptCommand, int>
    {
        private readonly IDepartment _idepartment;
        private readonly IMapper _mapper;

        public CreateDeptCommandHandler(IMapper mapper, IDepartment iDepartment)
        {
            _mapper = mapper;
            _idepartment = iDepartment;
        }
        public async Task<int> Handle(CreateDeptCommand request, CancellationToken cancellationToken)
        {
            Domain.Department Dept = _mapper.Map<Domain.Department>(request);


            Dept = await _idepartment.AddAsync(Dept);
            return Dept.Id;
        }

    }
}
