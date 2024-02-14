using MediatR;
using AutoMapper;
using MediatR;

using Demo.Applicatoin.Interfaces;

namespace Demo.Applicatoin.Features.User.Query.GitUserLIST
{
    public class GitUserListQueryHandler : IRequestHandler<GitUserListQuery, List<GituserlisVeiwModel>>
    {
        private readonly IMapper _mapper;
        private readonly IGitUserall _IGitUserall;

        public GitUserListQueryHandler(IMapper mapper, IGitUserall IGitUserall)
        {
            _mapper = mapper;
            _IGitUserall = IGitUserall;
        }


        public async Task<List<GituserlisVeiwModel>> Handle(GitUserListQuery request, CancellationToken cancellationToken)
        {
            var alluser = await _IGitUserall.GetAlluserAsync();
            return _mapper.Map<List<GituserlisVeiwModel>>(alluser);
        }

        
    }
}
