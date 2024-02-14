using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Applicatoin.Features.User.Query.GitUserLIST
{
    public class GitUserListQuery : IRequest<List<GituserlisVeiwModel>>
    {
    }
}
