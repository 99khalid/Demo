using AutoMapper;
using Demo.Applicatoin.Interfaces;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Applicatoin.Features.User.Query.Gituserdeatials
{
    public class GitUserDetailsHandler : IRequestHandler<GitUserDetailsQuery, GitUserDetailsviewmodel>
    {
        private readonly IMapper _mapper;
        private readonly IGitUserall _IGitUserall;

        public GitUserDetailsHandler(IMapper mapper, IGitUserall IGitUserall)
        {
            _mapper = mapper;
            _IGitUserall = IGitUserall;
        }

        public async Task<GitUserDetailsviewmodel> Handle(GitUserDetailsQuery request, CancellationToken cancellationToken)
        {
            var alluser = await _IGitUserall.GetuserAsyncbuid(request.id);
            return _mapper.Map<GitUserDetailsviewmodel>(alluser);
        }

    }
}
