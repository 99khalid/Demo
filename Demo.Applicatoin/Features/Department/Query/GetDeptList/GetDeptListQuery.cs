using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Applicatoin.Features.Department.Query.GetDeptList
{
    public class GetDeptListQuery : IRequest<List<GetDeptListViewModel>>
    {
    }
}
