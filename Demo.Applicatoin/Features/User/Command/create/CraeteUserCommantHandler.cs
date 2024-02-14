using AutoMapper;
using Demo.Applicatoin.Interfaces;
using MediatR;


namespace Demo.Applicatoin.Features.User.Command.create
{
    public class CraeteUserCommantHandler : IRequestHandler<CraeteUserCommant, int>
    {
        private readonly IMapper _mapper;
        private readonly IGitUserall _IGitUserall;

        public CraeteUserCommantHandler(IMapper mapper, IGitUserall IGitUserall)
        {
            _mapper = mapper;
            _IGitUserall = IGitUserall;
        }

        public async Task<int> Handle(CraeteUserCommant request, CancellationToken cancellationToken)
        {
            Domain.User user = _mapper.Map<Domain.User>(request);
            CraeteUserCommantValidator validator = new CraeteUserCommantValidator();
            var result = await validator.ValidateAsync(request);
            if (result.Errors.Any())
            {
                throw new Exception("user is not valid");
            }

            user =  await _IGitUserall.AddAsync(user);
            return user.Id;
        }
    }
}
