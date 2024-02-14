using AutoMapper;
using Demo.Applicatoin.Interfaces;
using MediatR;


namespace Demo.Applicatoin.Features.Department.Query.GetDeptList
{
    public class GetDeptListHandler : IRequestHandler<GetDeptListQuery, List<GetDeptListViewModel>>
    {
        private readonly IDepartment _idepartment;
        private readonly IMapper _mapper;

        public GetDeptListHandler(IMapper mapper, IDepartment iDepartment)
        {
            _mapper = mapper;
            _idepartment = iDepartment;
        }

        public async Task<List<GetDeptListViewModel>> Handle(GetDeptListQuery request, CancellationToken cancellationToken)
        {
            var allDepartments = await _idepartment.GetAllDeptAsync();
            return _mapper.Map<List<GetDeptListViewModel>>(allDepartments);
        }
    }
}
