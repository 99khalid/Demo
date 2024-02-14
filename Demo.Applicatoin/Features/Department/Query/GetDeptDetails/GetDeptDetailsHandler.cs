using AutoMapper;
using Demo.Applicatoin.Features.Department.Query.GetDeptList;
using Demo.Applicatoin.Features.User.Query.Gituserdeatials;
using Demo.Applicatoin.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Applicatoin.Features.Department.Query.GetDeptDetails
{
    public class GetDeptDetailsHandler :IRequestHandler<GetDeptDetailsQuery,GetDeptDetailsViewModel>
    {
        private readonly IMapper _mapper;
        private readonly IDepartment _ideparment ;


        public GetDeptDetailsHandler(IMapper mapper ,IDepartment department)
        {
            _mapper = mapper;
            _ideparment = department;
        }
        public async Task<GetDeptDetailsViewModel> Handle(GetDeptDetailsQuery request, CancellationToken cancellationToken)
        {
            var dept = await _ideparment.GetDeptAsyncbuid(request.id);
            return _mapper.Map<GetDeptDetailsViewModel>(dept);
        }


    }
}
